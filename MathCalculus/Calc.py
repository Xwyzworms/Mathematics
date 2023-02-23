#%%
import numpy as np
import matplotlib.pyplot as plt
from typing import List
import sympy as sym

xDomain : List[int]  = [-2, 2]


#[-2, 2)
# Create the range()
#option 1
resolution : float = .1
x : np.array = np.arange(xDomain[0], xDomain[1] + resolution, resolution) 
print(x)

#option 2
x = np.linspace(xDomain[0], xDomain[1], 41) # Use 41, because we want to include zero

# Plug in the X to y:
y : np.array = x**2 + 3*x**3  - x**4 
print("\n The Range values are : %s " %(y))

plt.plot(x,y, label="$y=x^2+3*x^3 - x^4$")
plt.grid()
plt.legend()
plt.xlim(xDomain[0], xDomain[1])
plt.xlabel("x")
plt.ylabel("y = f(x)")
plt.show() 

# %%
s_beta : sym.var = sym.var("beta")

# Define the function
s_y  = s_beta**2 + 3*s_beta**3 - s_beta**4

sym.plot(s_y, (s_beta, xDomain[0],xDomain[1]), xlabel="x", ylabel=None, title=f'$f(\\beta) = {sym.latex(s_y)}$')

#%% Sympy to Function

fx = sym.lambdify(s_beta, s_y)
y = fx(x)

#%%
plt.plot(x,y, label="$y=x^2+3*x^3-x^4")
plt.grid()
plt.xlim(xDomain[0], xDomain[1])
plt.xlabel("x")
plt.ylabel("y=f(x)")
plt.show()

