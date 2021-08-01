# DDF

Differential Direction Field. A windows forms app for estimating solutions to first order differential equations.

This app allows you to input a differential equation and an initial value so a particular solution can be determined. It will then calculate a specified number of estimates and plot them on a graph.

## Installation

If you want to clone/download this repository and run the code yourself:  
The code relies on the nuget packages `OxyPlot.WindowsForms` and `MathParser.org-mXparser`. You may need to install these packages manually.

For a prebuilt version, head over to the [releases](https://github.com/maxymoo22/DifferentialDirectionField/releases/latest) page to get the latest `.exe`.

## Usage

<img src="/demo.png" alt="Example"/>  
Put your differential equation into the input box on the left. Just to be annoying, it requires dx/dt instead of dy/dx. Choose an initial value so the program can get the specific solution. The step size is the distance between points. A smaller step size will produce a more accurate graph. You can also choose the number of points to estimate - a large number of points may take some time.  
In the example above, I've put dx/dt = x as the differential equation. With a starting value of (0, 1), we can see (from looking at the estimate) that the solution curve looks like an exponential.  
Note that this is just an example. dx/dt = x is simple to solve (we know that the solution curve is x=e^t), so we don't need to use this program. It is intended for more complicated equations that do not have explicit solutions.