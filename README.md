# Net_Core_Angular_SQLServer_01
Desarrollo frontend con Angular 11, Bootstrap 5.1.3, backend NET Core, Entity Framework Core, SQL Server + Deploy en Azure


## FrontEnd

* **https://getbootstrap.com/**
* **https://github.com/twbs/bootstrap**
* **https://uigradients.com/#CrystalClear**
* **https://codingpotions.com/angular-componentes-routing**

```
Angular 11
Bootstrap 5.1.3

npm install ngx-toastr@13.2.1 --save

npm install bootstrap

CSS:

Import bootstrap.min.css in file styles.scss

// Bootstrap
@import "~bootstrap/dist/css/bootstrap.min.css";

OR

Add path in file angular.json

"styles": [
              "src/styles.scss",
              "node_modules/bootstrap/dist/css/bootstrap.min.css"
          ],

// PATH (Bootstrap): "node_modules/bootstrap/dist/css/bootstrap.min.css"

JS:

Add path in file angular.json

"scripts": [
              "node_modules/bootstrap/dist/js/bootstrap.min.js"
           ]

Or

Bundle (*)

Include every Bootstrap JavaScript plugin and dependency with one of our two bundles. Both bootstrap.bundle.js and bootstrap.bundle.min.js include Popper for our tooltips and popovers. For more information about what’s included in Bootstrap, please see our contents section.

"scripts": [
              "node_modules/bootstrap/dist/js/bootstrap.bundle.min.js"
           ]



ANOTHER WAY:

https://www.crehana.com/ec/blog/desarrollo-web/instalar-bootstrap-angular/

https://www.crehana.com/ec/blog/desarrollo-web/instalar-bootstrap-angular/

Luego, en el archivo “angular.json”, deberás poner las siguientes instrucciones en los objetos “styles” y “scripts”:

    "styles": [
    "node_modules/bootstrap/dist/css/bootstrap.min.css",
    "src/styles.scss"
    ],
    "scripts": [
    "node_modules/jquery/dist/jquery.min.js",
    "node_modules/@popperjs/core/dist/umd/popper.min.js",
    "node_modules/bootstrap/dist/js/bootstrap.min.js"
    ]

```

## Páginas y rutas Angular SPA (route:slug)

* **https://academia-binaria.com/paginas-y-rutas-angular-spa/**

```
Bloc
```


## BackEnd

```
Create new controller

Instalar dependecias y creacion del model:

- Tools > NuGet Package Manager > Manage NuGet Packages for solution...
- Browser >
* Entity framework core → (Crea la base datos - ORM) → 5.0.11
* Entity framework tools → (Migraciones y actualizaciones a la BD) → 5.0.11
* Entity framework sql server → (Conector de Sql Server) → 5.0.11


.AspNetCore → 5.0.11
.Net Core → 5.0.11

CMD:

dotnet --version
5.0.402

.NET → 5.0.402


```

## Migrations
* **https://www.entityframeworktutorial.net/efcore/entity-framework-core-migration.aspx**

```
- Tools > NuGet Package Manager > Packages Manager Console

Add-Migration name_migration
Add-Migration v1.0.0
Update-database


remove-migration

```



## Entity Framework Core
* **https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx**
* **https://www.entityframeworktutorial.net/code-first/dataannotation-in-code-first.aspx**
* **https://es.stackoverflow.com/questions/283482/entity-framework-dbcontext-que-es**

```
Entity Framework Core
Data Annotations Attributes in EF 6 and EF Core (*)
Entity Framework: DbContext ¿Que es?
```

## SQL SERVER

* **https://aspnetcoremaster.com/connectionstring/2019/02/27/cadenas-de-conexion-csharp.html**
* **https://www.sysadmit.com/2019/02/sqlserver-como-saber-nombre-instancia.html**
* **https://www.w3schools.com/sql/sql_insert.asp**

```
Cadena de conexión:

Conexión Sin instancia (OK - SQL Server 2019 Developer):

Server=(local)\\;Database=netcore_db_01;Trusted_Connection=True;MultipleActiveResultSets=True


Cuando se instala SQLServer en un equipo, se genera la instancia predeterminada (DEFAULT INSTANCE)
y no se requiere que un cliente especifique el nombre de la instancia para establecer una conexión:
El cliente solo tiene que saber el nombre del servidor.

Igualmente, el nombre de la instancia predeterminada se llama: MSSQLSERVER

https://www.sysadmit.com/2019/02/sqlserver-como-saber-nombre-instancia.html




Other:

Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;Application Name=MyApp

Server=(local)\localhost;Database=netcore_db_01;Trusted_Connection=True;MultipleActiveResultSets=True

Server=(local)\mssqllocaldb;Database=netcore_db_01;Trusted_Connection=True;MultipleActiveResultSets=True




Cuando se instala SQL Server 2019 Express:

Server=(local)\\sqlexpress;Database=netcore_db_01;Trusted_Connection=True;MultipleActiveResultSets=True

Por tanto, para conectar a una instancia  desde el lado cliente a SQLExpress, especificaremos: Nombre-Servidor\SQLExpress

https://www.sysadmit.com/2019/02/sqlserver-como-saber-nombre-instancia.html



CMD:

sqllocaldb
sqllocaldb i
sqllocaldb -?

ERROR:

A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SNI_PN11, error: 26 - Error Locating Server/Instance Specified)



SqlLocalDB treats spaces as delimiters. It is necessary to surround
instance names that contain spaces and special characters with quotes.
For example:
   SqlLocalDB create "My LocalDB Instance"

The instance name can sometimes be omitted, as indicated above, or
specified as "". In this case, the reference is to the default LocalDB
instance "MSSQLLocalDB".

Solución Sin instancia:

Server=(local)\\;Database=netcore_db_01;Trusted_Connection=True;MultipleActiveResultSets=True

Otra solución (No probada):

Server=(localdb)\\MSSQLLocalDB;Database=netcore_db_01;Trusted_Connection=True;MultipleActiveResultSets=True


```

## Tecnologías

```

Tecnologías:

FronEnd: Angular, HTML, CSS JavaScript y Boostrap 4

BackEnd: NET Core 5.0.11

ORM: Entinty Framework 5.0.11

Base de datos: SQL Server

Deploy: Azure (BackEnd) FrontEnd (Netifly).

```

## Sql Server

```


```