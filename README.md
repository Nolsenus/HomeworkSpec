# Решение задачи по формированию массива строк длиной не больше трёх символов из исходного массива строк #

## 1. Получение исходного массива ##

В своём решении я выбрал ввод исходного массива пользователем с клавиатуры. Для этого необходимо следующее:

1. Завести переменную под размер массива.
2. Получить размер массива от пользователя и занести его в заведённую переменную.
3. Объявить массив строковых переменных заданной размерности.
4. В цикле поочерёдно получить от пользователя строки и занести их в массив.

## 2. Решение задачи ##

1. Завести целочисленную переменную-счетчик, инициализированную нулём, в которой будет храниться количество строк длиной три и меньше.
2. В цикле посчитать (увеличивая переменную из пункта 1) количество строк в исходнос массиве, длина которых три и меньше.
3. Завести массив строковых переменных длиной равной полученному в пункте 2 значению, который будет хранить решение задачи.
4. Если длина результирующего массива оказалась равна нулю, то из функции сразу возвращается пустой массив.
5. Завести целочисленную переменную - указатель на первый пустой элемент результирующего массива (изначально равна нулю).
6. В цикле пройтись по всем элементам изначального массива и если их длина не больше трёх, то записать их значение в результирующий массив по индексу равному переменной из пункта 5, после чего увеличить эту переменную на 1.
7. Вернуть из функции результирующий массив.