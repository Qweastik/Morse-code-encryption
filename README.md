# Morse-code-encryption
### Клименко С
### ПОКС-32
Данная программа предназначена для шифрования и дешифрования кириллицы азбукой морзе.  Символы, шифруемые программой содержатся в массиве characters, а последовательность кода азбуки морзе для этих символов в массиве codeMorse. При нажатии кнопки зашифровать, текст из textBox1 переносится в переменную input, которая в дальнейшем посимвольно перебирается в цикле foreach. С помощью метода IndexOf() для каждого символа выполняется поиск соответствующего ему символа из массива codeMorse. С помощью метода Remove() удаляется последний символ в строке output, являющийся пробелом, после чего результат шифрования выносится в textBox2. Процесс дешифровки по азбуке морзе реализован по аналогии с шифрованием.
