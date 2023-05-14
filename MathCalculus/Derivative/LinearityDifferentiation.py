#%%
import numpy as np
import sympy as asm # NOW PLEASE DON'T MADE
import matplotlib.pyplot
from IPython.display import display, Math
#%%
x,a,b,c = asm.symbols("x,a,b,c")

f_x = a*x**2 + b*x**3 + c*asm.exp(2*x)

display(Math("\\text{Derivative of f(x) is => }%s" %(asm.latex(asm.diff(f_x,x)))))



listOfDerivative = 0
for fun in f_x.args:
    dy = asm.diff(fun, x)
    
    display(Math("\\text{Derivative of } %s \\text{ is } %s" %(asm.latex(fun), asm.latex(dy))))
    listOfDerivative += dy
display(Math("\\text{Combined Derivative : } %s" %(asm.latex(listOfDerivative))))
#%%
## Rules 2 d/dx (ax**2) == a(d/dx(x**2))
x,a = asm.symbols("x,a")

f_1 = a*x**2
f_2 = x**2 # Save the A later


dy_f1 = asm.diff(f_1,x)
dy_f2 = asm.diff(f_2,x)

display(Math("\\text{Derivative of f(x) is =>} %s" %(asm.latex(dy_f1))))
display(Math("\\text{Derivative of g(x) is =>} %s" %(asm.latex(a*dy_f2)))) # Doing the outside a calculation
#%%
## COMBINED RULES 

