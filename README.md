# API Store User Login

Store User Login is a demo program to show how you can store some information when users sign in into your system. This is an API built on NET Core 5.0 - C#. The database model is managed using Microsoft Entity Framework core.


## Dependencies

![](https://img.shields.io/badge/dependencies-dotnetCore-red) 

![](https://img.shields.io/badge/dependencies-Entity_Framework-red)

![](https://img.shields.io/badge/dependencies-Entity_Framework_Tools-red)



# Usage
### User Login Table
In this repository there is a file UserLoginTable.sql, this file create for you the userLoginTable in the Database.

**Note**: The UserLoginTable.sql expects SGA as database name. If your database has different name, you should change it in the first line of this file.

### Setup Database String Connection
You must setup Database String Connection in **SGAContext.cs** file. This String Connection could be hardcoded (not recommended) or getting from a config file. Other option is getting the String Connection from a webservice.

#### Hardcode Option

```C#
 optionsBuilder.UseSqlServer("Server=192.168.56.101; Database=SGA; Trusted_Connection=false; User=sa; Password = 123456");
```

#### Config File Option
```C#
String configString = System.IO.File.ReadAllText("appsettings.json");
 dynamic configObject = JsonConvert.DeserializeObject<dynamic>(configString);

 optionsBuilder.UseSqlServer(configObject.DBStringConnection);
 
			
```
#### AppSetting.json
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "DBStringConnection": "Server=192.168.56.101; Database=SGA; Trusted_Connection=false; User=sa; Password = 123456"
}
```

## License

MIT License

Copyright (c)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.