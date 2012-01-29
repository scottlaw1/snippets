<Query Kind="Expression">
  <Connection>
    <ID>896a64d8-7f10-47ec-b0b7-8687201259df</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Northwind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

(from o in Orders select Convert.ToDateTime(o.OrderDate).Year).Distinct()