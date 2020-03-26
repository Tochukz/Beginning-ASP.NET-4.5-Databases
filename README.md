# Beginning ASP.NET 4.5 Databases 3rd Edition (2013)
__by Sandeep Chanda and Damien Foggon__  

## Chapter 1: ASP.NET 4.5 Data Sources
How will you design a web application that delivers content bases on user's location?
What is an atomic database transaction/.

__The New Data Access Paradigms__
_Entity Models_ is an Entity Relationship Diagram generated from the database schema typically with the help of a conceptual model generator. Microsoft .NET Framework 4.5 features a built-in model generator in the ADO.NET Entity Framework.  

Two work flows in building a data access layer:
1. _Design Centric Approach_ where you generate an Entity Model and Entity classes from an existing or newly created database schema.
2. _Code Centric Approach_  where you create the Entity model first and generate the database schema and entity classed from the model.   

The _Code Centric Approach_ is simpler, offers greater flexibility and control and it is often easier for multitargeted deployment scenarios.  

For an existing database, the _Design Centric Approach_ is easier.  

__NoSQL__  
A Blog is a good example of the use of _NoSQL_ databases as a data store. Content Management Systems are also good examples where _NoSQL_ database are better suited than traditional relational database management systems.  
The most popular ones are _MongoDB_ and _CouchDB_. They have different priority - _MongoDB_ focuses on high performance, while _CouchDB_ is geared towards high concurrency.  

__Web Services__  
In .NET, services have transformed from _web service enhancements (WSE)_ that leveraged the WS* specifications to a full-fledged framework feature in the form pf WCF, first introduced in .NET Framework 3.0  

__ADO.NET and LINQ__  
Several flavors of LINQ are in place for ADO.NET:
* LINQ to DataSet  
* LINQ to SQL
* LINQ to Entities  

__Data Providers__  
The _EntityClient_ provider does not interact with a data source directly. It acts as a bridge between other native providers like _SqlClient_ and _OracleClient_ using Entity SQL.  
The connection string information for _EntityClient_ is different from a regular connection string.  

__Async Programming Model in.NET Framework 4.5__  
Asynchronous operations are not supported if the attribute _Context Connection_ is set to `true` in the connection string.

To continue...

## Chapter 4: Accessing Data Using ADO.NET
__DataSet vs. DataReader__  
_Data Reader_ is faster than _DataSet_ for accessing data in a forward-only, read-only fashion.  _DataSet_, is a powerful means of holding data in memory and performing manipulations on it. Also god for multiple heterogeneous data sources.

__Connecting to a Database__   
**Caution** Integrated authentication is the preferred means of connecting to a database. If you have to use the database credentials, then make sure that the . _Persist Security Info_ attribute is set to `false`. In addition, encrypt the sensitive credential information in the configuration file. You can use the _ASPNET_REGIIS_ command with the `-pe` switch in the Visual Studio Tools Command Prompt to encrypt specific configuration sections.
