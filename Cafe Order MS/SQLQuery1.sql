select * from customer;
select * from Orders;
select * from Orders where CustomerId = 2;

alter table orders add CustomerId int foreign key references Orders(OrderId);
