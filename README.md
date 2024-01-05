# Итоговая контрольная работа по основному блоку

## Что нужно сделать:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

## Описание решения
### Поставленная задача будет решена с использованием изученной базы языка программирования C#.

* *Вначале создаём массив из строк с именем* array.
* *После этого создаём пустой массив* arr1 *с длиной* - array.Lenght.
* *Далее при помощи цикла* for *проходимся по элементам массива* array 
* *При условии, что если длина элемента массива* array <= 3, *этот элемент добавляется 
в массив* arr1.
* *После убираем пустые элементы в массиве* arr1 *и выводим в консоль оба массива, как до и после.*