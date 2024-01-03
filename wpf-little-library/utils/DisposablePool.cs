using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace io.github.toyota32k.toolkit.utils {
    public class DisposablePool : List<IDisposable>, IDisposable {
        public void Reset() {
            foreach (var e in this) {
                e.Dispose();
            }
            Clear();
        }

        public void Dispose() {
            Reset();
        }
    }
}
