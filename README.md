This repository demonstrates a subtle bug in F# related to mutable variables. The `bug.fs` file contains code that calculates a sum using mutable variables. However, changing the mutable variables after the calculation does not update the result. The `bugSolution.fs` file shows how to address this using immutable variables or by recalculating the sum.