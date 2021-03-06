﻿Данная программа на языке программирования C#, 
производит моделирование работы планировщиков задач методами управления ресурсами многопроцессорных 
систем при обработке пакетов задач с прерываниями используя алгоритм Макнотона, 
заключающийся в предварительном упорядочении задач по убыванию времени решения и назначении задач 
последовательно по порядку номеров одну за другой на процессоры системы с не более чем n-1 прерываниями, 
так, как после прерывания решение задачи может быть возобновлено с точки прерывания на любом процессоре, 
при этом число прерываний должно быть по возможности меньшим, так, 
как с каждым актом прерывания связаны потери машинного времени на загрузку-выгрузку задач из оперативной памяти.  

Основной модуль UpravlenieResursamiOdnoprocessornihSystem содержит основную функцию Main – 
выполняющую задачу ввода количества общих заданий на все процессоры и количества идентичных процессоров 
для обработки этих общих заданий, также в данной функции происходит случайная инициализация массива с 
различным временем выполнения для введенных пользователем заданий, сортировка массива с перестановкой 
элементов, чтобы они были убывающими, задание значения нижней границы времени для алгоритма Макнотона, 
где для задания значения нижней границы берутся данные из метода middleOfSum о нужном количество квантов 
процессорного времени для расчета всех задач. В данной функции высчитывается время простаивания любого из процессоров, 
где данные о простаивании берутся из метода AlgorithmMaknoton. 
Также эта функция выводит данные о простаивании одного из процессоров и время оптимальной работы алгоритма.  

Методы с которыми работает основная функция:
1)	метод middleOfSum – считает потраченное время на решение всех заданий и делит его на время 
кванта процессорного времени, чтобы узнать нужное количество квантов для выполнения заданий на единственном 
процессоре. Передает данные о нужном количестве квантов в основную функцию Main;
2)	метод AlgorithmMaknoton – заполняет и распределяет работу на каждом процессоре в виде вместившихся 
полностью и не вместившихся на процессор заданий, где не вместившееся на процессор задание переходит на 
следующий процессор. Также в данном методе вычитается потраченное на задание время, чтобы выявить время 
простаивания любого из процессоров. Передает данные о времени простаивания любого из процессоров в основную функцию Main.
