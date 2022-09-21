# Exam
Итоговая проверочная работа.
Алгоритм решения задачи находится в методе findShortStrings. 
В качестве входных данных метод получает массив строк и возвращает массив, состоящий из строк исходного массива, длина которых не превышает 3 символов.
Сначала алгоритм проходит по исходному массиву, считывает количество строк, длина которых меньше либо равна 3 символам, и хранит это количество в переменной size.
Затем создаётся массив с названием result длины size, чтобы записать в него все такие строки.
После этого алгоритм ещё раз проходит по исходному массиву и записывает строки, длина которых не превышает 3 символов, в массив result.
Теперь результат работы алгоритма хранится в result, и именно этот массив возвращает метод.
Также следует отметить, что если в исходном массиве не будет строк, длина которых не превышает 3, то по данному алгоритму просто будет создан массив длины 0, в котором не будет ни одной строки.
Для работы с методом findShortStrings создан метод Main, в котором пользователь может через консоль ввести массив строк, над которым будет выполнен алгоритм.
Для этого необходимо сначала ввести количество строк, а затем сами строки. Результат работы алгоритма будет выведен в консоль.
