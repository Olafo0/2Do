CREATE TABLE tbl_2DoList(
  ToDoID int PRIMARY KEY IDENTITY(1,1),
  ToDoTitle varchar(40),
  ToDoDesc varchar(500),
  Done int,
  DateCreated DateTime,
  DateDone DateTIme,
  PriorityTask int)
