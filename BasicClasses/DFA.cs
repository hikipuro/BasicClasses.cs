using System.Collections.Generic;

namespace BasicClasses {
	public class DFA<T> {
		public State StartState;
		protected readonly List<State> _states;

		public int Count {
			get { return _states.Count; }
		}

		public DFA() {
			_states = new List<State>();
		}

		public bool Has(State state) {
			return _states.Contains(state);
		}

		public void Add(State state) {
			_states.Add(state);
		}

		public void Remove(State state) {
			_states.Remove(state);
		}

		public bool Accepts(IEnumerable<T> list) {
			State state = StartState;
			foreach (T item in list) {
				if (_states.Contains(state) == false) {
					return false;
				}
				state = state.TransitionTo(item);
			}
			if (_states.Contains(state)) {
				return state.IsAccept;
			}
			return false;
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
