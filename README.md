# EmployeeAPI

Тестовое задание: Создать API для взаимодействия с клиентским приложением

Использован шаблон ASP.NET Core Web API 

Для хранения данных использована СУБД Postgesql, Code First

Для взаимодействия с СУБД использован Entity Framework Core и пакет Npgsql.EntityFrameworkCore.Postgresql

Путь api/positions - доступ к таблице должностей

Путь api/employees - доступ к таблице сотрудников

На стартовой странице (путь api/employeeposition) выдается результат соединения вышеуказанных таблиц

Доступ к данным - GET запрос для получения данных, POST для создания записей, PUT для редактирования, DELETE для удаления.

Проверка работоспособности произведена через Postman.
