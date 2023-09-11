/*Так как в указанном случае используется связь многие ко многим, в БД есть 3 таблицы. Допустим:
Таблица продуктов - Products со столбцами ID и Name
Связующая таблица - Products_Categories ID_product и ID_Category
Таблица категорий - Categories ID и Name

Запрос будет выглядеть следующим образом*/

SELECT p.ID, p.name, с.ID, с.name
FROM Products p
LEFT JOIN Products_Categories pс
ON p. Id = pс. ID_product
LEFT JOIN Categories c
ON pс. ID_Category = c.Id 
ORDER BY s.name
