<Query Kind="Expression">
  <Connection>
    <ID>76edea29-dab2-4854-bc76-04be9ee96831</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://data.stackexchange.com/stackoverflow/atom</Server>
  </Connection>
</Query>

from user in Users
where user.DisplayName.Contains("Scott A. Lawrence")
select user