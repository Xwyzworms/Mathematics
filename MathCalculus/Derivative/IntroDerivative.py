#%%
import numpy as np
import matplotlib.pyplot as plt
#TODO 

#1 Plot Points ( -1,1) and (3,6) and the line in between

point_1 = [-1,1]
point_2 = [3,6]

plt.plot([point_1[0],point_2[0]], [point_1[1],point_2[1]])
plt.plot(point_1[0],point_1[1],'ro',label="point1")
plt.plot(point_2[0],point_2[1],"bs",label="point2")
deltaX = point_2[0] - point_1[0]
deltaY = point_2[1] - point_1[1]

plt.plot([0,0],[-2,7], "k--",linewidth=.3)
plt.plot([-2,7], [0,0], "k--", linewidth=.3)

plt.title(f"The Slope of the line  is m={deltaY/deltaX}")
plt.xlim(-2,7)
plt.ylim(-2,7)

# %%
#TODO 

N=10
x = np.linspace(-1,5,N)
fx = x**2

plt.plot(x, fx,"bo")
plt.plot(x, fx)
deltaX = np.array([x[i+1] - x[i] for i in range(len(x) -1 )])
deltaY = np.array([fx[i+1] - fx[i] for i in range(len(x) -1)])

print((x[:-1]+deltaX)**2 - fx[:-1])
print(deltaY)

slope = deltaY / deltaX
plt.title("Some useless Function")
plt.show()

for i in range(0, N-1):
    plt.plot([x[i],x[i+1]], [slope[i],slope[i]] )

#%%
#TODO 

print(slope)
globalSlopeX = x[-1] - x[0]
globalScopeY = fx[-1] - fx[0]

mGlobalScope = globalScopeY / globalSlopeX
averageLocalScope = np.average(slope)

print(f"Global Scope {mGlobalScope}")
print(f"Average Local Slope {averageLocalScope}")
