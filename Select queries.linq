<Query Kind="Statements">
  <Connection>
    <ID>54bf9502-9daf-4093-88e8-7177c12aaaaa</ID>
    <NamingService>2</NamingService>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\ChinookDemoDb.sqlite</AttachFileName>
    <DisplayName>Demo database (SQLite)</DisplayName>
    <DriverData>
      <PreserveNumeric1>true</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.Sqlite</EFProvider>
      <MapSQLiteDateTimes>true</MapSQLiteDateTimes>
      <MapSQLiteBooleans>true</MapSQLiteBooleans>
    </DriverData>
  </Connection>
  <Output>DataGrids</Output>
</Query>

//----------------------------------------------------------//
var q1 =from a in Albums
    	select a;
q1.Dump("All column");

//----------------------------------------------------------//
//If you select one field, you can just write select a.Title.
//If you want multiple fields, wrap them in new { ... } to make an anonymous object.
var q2 =from a in Albums
	    select a.Title;
q2.Dump("1 column");

//----------------------------------------------------------//
var q3 =from a in Albums
	    select new 
	    {
	        a.Title,
	        a.AlbumId
	    };
q3.Dump("more than 2 column");

//----------------------------------------------------------//



