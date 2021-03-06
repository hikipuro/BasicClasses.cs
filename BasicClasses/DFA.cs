namespace BasicClasses {
	using System.Collections.Generic;

	public class DFA<T> {
		public State InitialState;
		protected readonly HashSet<State> _states;

		public int Count {
			get { return _states.Count; }
		}

		public DFA() {
			_states = new HashSet<State>();
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
			State state = InitialState;
			if (_states.Contains(state) == false) {
				return new Result(false, 0, null);
			}
			int i = 0;
			foreach (T item in list) {
				if (state.Transitions.TryGetValue(item, out State nextState)) {
					if (_states.Contains(nextState) == false) {
						return new Result(false, i, state);
					}
					state = nextState;
					i++;
					continue;
				}
				return new Result(false, i, state);
			}
			if (_states.Contains(state)) {
				return new Result(state.IsAccept, i, state);
			}
			return new Result(false, i, state);
		}

		public struct Result {
			public bool IsAccept;
			public int Index;
			public State State;

			public Result(bool isAccept, int index, State state) {
				IsAccept = isAccept;
				Index = index;
				State = state;
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
			public readonly Dictionary<T, State> Transitions;

			public State this[T key] {
				get {
					if (Transitions.TryGetValue(key, out State state)) {
						return state;
					}
					return null;
				}
				set {
					if (Transitions.ContainsKey(key)) {
						Transitions[key] = value;
						return;
					}
					Transitions.Add(key, value);
				}
			}

			public State() {
				Transitions = new Dictionary<T, State>();
			}

			public State(string name) : this() {
				Name = name;
			}

			public void Add(T key, State state) {
				if (Transitions.ContainsKey(key)) {
					Transitions[key] = state;
					return;
				}
				Transitions.Add(key, state);
			}

			public bool Remove(T key) {
				return Transitions.Remove(key);
			}

			public State TransitionTo(T key) {
				if (Transitions.TryGetValue(key, out State state)) {
					return state;
				}
				return null;
			}
		}
	}
}
