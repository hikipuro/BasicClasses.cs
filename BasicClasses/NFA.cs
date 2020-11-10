using System.Collections.Generic;

namespace BasicClasses {
	public class NFA<T> {
		public State InitialState;
		protected readonly StateSet _states;

		public int Count {
			get { return _states.Count; }
		}

		public NFA() {
			_states = new StateSet();
		}

		public bool Has(State state) {
			return _states.Contains(state);
		}

		public State Add() {
			State state = new State();
			_states.Add(state);
			return state;
		}

		public void Add(State state) {
			_states.Add(state);
		}

		public void Remove(State state) {
			_states.Remove(state);
		}

		public Result Accepts(IEnumerable<T> list) {
			if (_states.Contains(InitialState) == false) {
				return new Result(false, 0, null);
			}
			StateSet states = new StateSet(InitialState);
			StateSet nextStates = new StateSet();
			int i = 0;
			foreach (T item in list) {
				foreach (State state in states) {
					if (_states.Contains(state) == false) {
						continue;
					}
					nextStates.UnionWith(state.TransitionTo(item));
				}
				if (nextStates.Count <= 0) {
					return new Result(false, i, states);
				}
				StateSet temp = states;
				states = nextStates;
				nextStates = temp;
				nextStates.Clear();
				i++;
			}
			foreach (State state in states) {
				if (_states.Contains(state) == false) {
					continue;
				}
				if (state.IsAccept) {
					return new Result(true, i, states);
				}
				foreach (State s in state.GetAllEpsilonTransitions()) {
					if (_states.Contains(s) == false) {
						continue;
					}
					if (s.IsAccept) {
						return new Result(true, i, states);
					}
				}
			}
			return new Result(false, i, states);
		}

		public struct Result {
			public bool IsAccept;
			public int Index;
			public StateSet States;

			public Result(bool isAccept, int index, StateSet states) {
				IsAccept = isAccept;
				Index = index;
				States = states;
			}

			public override string ToString() {
				return string.Format(
					"IsAccept: {0}, Index: {1}",
					IsAccept, Index
				);
			}
		}

		public class State {
			public bool IsAccept;
			public string Name;
			public readonly Dictionary<T, StateSet> Transitions;
			public readonly StateSet EpsilonTransitions;

			public State() {
				Transitions = new Dictionary<T, StateSet>();
				EpsilonTransitions = new StateSet();
			}

			public State(string name) : this() {
				Name = name;
			}

			public StateSet GetAllEpsilonTransitions() {
				if (EpsilonTransitions.Count <= 0) {
					return new StateSet();
				}
				StateSet states = new StateSet();
				foreach (State state in EpsilonTransitions) {
					if (state == null || states.Add(state) == false) {
						continue;
					}
					states.UnionWith(state.GetAllEpsilonTransitions());
				}
				return states;
			}

			public void Add(T key, State state) {
				if (Transitions.ContainsKey(key) == false) {
					Transitions.Add(key, new StateSet());
				}
				Transitions[key].Add(state);
			}

			public void AddEpsilon(State state) {
				EpsilonTransitions.Add(state);
			}

			public void Remove(T key) {
				if (Transitions.ContainsKey(key) == false) {
					return;
				}
				Transitions.Remove(key);
			}

			public void Remove(T key, State state) {
				if (Transitions.ContainsKey(key) == false) {
					return;
				}
				Transitions[key].Remove(state);
			}

			public void RemoveEpsilon(State state) {
				EpsilonTransitions.Remove(state);
			}

			public StateSet TransitionTo(T key) {
				StateSet states;
				if (Transitions.TryGetValue(key, out StateSet set0)) {
					states = new StateSet(set0);
				} else {
					states = new StateSet();
				}
				foreach (State state in EpsilonTransitions) {
					states.UnionWith(state.TransitionTo(key));
				}
				return states;
			}
		}

		public class StateSet : HashSet<State> {
			public StateSet() : base() {
			}

			public StateSet(State state) : base() {
				Add(state);
			}

			public StateSet(IEnumerable<State> collection) : base(collection) {
			}
		}
	}
}
