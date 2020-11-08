using System.Collections.Generic;

namespace BasicClasses {
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
					state = nextState;
					if (_states.Contains(state) == false) {
						return new Result(false, i, state);
					}
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
			public readonly Dictionary<T, State> Transitions;

			public State() {
				Transitions = new Dictionary<T, State>();
			}

			public void Add(T key, State state) {
				Transitions.Add(key, state);
			}

			public void Remove(T key) {
				Transitions.Remove(key);
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
