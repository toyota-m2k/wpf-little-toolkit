using System;

namespace io.github.toyota32k.toolkit.utils {
    internal class GenericDisposable : IDisposable {
        Action mDisposer;

        public GenericDisposable(Action disposer) {
            mDisposer = disposer;
        }

        public void Dispose() {
            mDisposer?.Invoke();
            mDisposer = null;
        }

        public static IDisposable Create(Action creator, Action disposer) {
            creator?.Invoke();
            return new GenericDisposable(disposer);
        }
        public static IDisposable Create(Func<Action> creator) {
            var disposer = creator.Invoke();
            return new GenericDisposable(disposer);
        }
    }
}
