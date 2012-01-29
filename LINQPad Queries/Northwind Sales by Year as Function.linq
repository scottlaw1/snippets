<Query Kind="Statements">
  <Connection>
    <ID>896a64d8-7f10-47ec-b0b7-8687201259df</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Northwind</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

var beginningDate = new DateTime(1996,1,1);
var endingDate = new DateTime(1996,12,31);

SalesbyYear (beginningDate,endingDate).Dump("Sales for 1996");