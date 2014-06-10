<Query Kind="Expression">
  <Connection>
    <ID>758bb229-4cc9-47ee-9ce7-50adef9a9f4a</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Northwind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from cust in Customers
where cust.City == "London" //&& cust.ContactName.Contains("Devon")
orderby cust.ContactName
select cust