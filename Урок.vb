Import system

Module progrem
Sub main(args AS String())
'TOOO: Генереруем число
Din number As String = "1234"
Console.WriteLine("Угадай число")
Din number As String 
Do
ver= Console.ReadLine ()
For i As Integer = 0 to 3
If ver.Chars(0) = number.Chars(i) then
if i= 0 Then
Console.WriteLine("{Первая цифра вашей версии - бык")
Else
Console.WriteLine("{Первая цифра вашей версии - корова")
End if
End if
Next
Console.WriteLine(ver.Chars(0))
if number=ver then
Console.WriteLine("Угадал!")
Else
Console.WriteLine("Ошибка")
End if