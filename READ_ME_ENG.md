This program is in the C# programming language,
Models the work of task schedulers with multiprocessor resource management methods.
systems when processing task packets with interruptions using the MacNaughton algorithm,
consisting in the preliminary ordering of tasks by decreasing the time of solving and assigning tasks
sequentially in order of numbers one by one to the system processors with no more than n-1 interrupts,
as after interruption the solution of the problem can be resumed from the point of interruption on any processor,
however, the number of interrupts should be as small as possible, so
As with each interrupt, the loss of computer time for loading and unloading tasks from RAM is associated.

The main module UpravlenieResursamiOdnoprocessornihSystem contains the main function Main -
performing the task of entering the number of common tasks for all processors and the number of identical processors
to handle these common tasks, also in this function, a random initialization of the array with
different execution times for user-entered tasks, array sorting with permutation
elements so that they are decreasing, setting the value of the lower bound of time for the McNaughton algorithm,
where to set the value of the lower boundary, the data from the middleOfSum method about the required number of quanta are taken
CPU time to calculate all tasks. This function calculates the idle time of any of the processors,
where data on idleness are taken from the AlgorithmMaknoton method.
This function also displays data about the idleness of one of the processors and the time of the optimal operation of the algorithm.

Methods with which the main function works:
1) middleOfSum method - considers the time spent on solving all tasks and divides it by time
CPU time quantum to find out the right amount of quanta for performing tasks on a single
the processor. Transmits data on the required number of quanta to the main function Main;
2) the AlgorithmMaknoton method - fills in and distributes the work on each processor as contained
completely and tasks that did not fit in the processor, where the task not contained in the processor goes to
next processor. Also in this method the time spent on the task is subtracted to reveal the time
idle of any of the processors. Sends the idle time of any of the processors to the main function Main.