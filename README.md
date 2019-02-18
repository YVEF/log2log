
<body>

<h3>Log2log is a logger for .Net Framework </h3>

<div>
<p>
Please, add this settings in your App/Web.config:
    </p>
</div>

```xml
<configSections>
    <section name="log2log" type="log2log.Configuration.LogConfigSection, log2log "/>
</configSections>

<log2log>
    <settings>
      <setting name="log2log" path="Log\LogFile.txt" levelFilter="false"/>
    </settings>
</log2log>
```

<p>
<em>
<br/>
<strong>Name</strong> is just a name of logger.
<br/>
<strong>Path</strong> is the path of create a .log file with/without subdirectory (By default, the .log is creates in the main directory of project)
<br/>
<strong>LevelFilter</strong> is enables or disables filtering by level. (Now is not available)
</em>
</p>


```csharp
using log2log;

// Create a logger instance
ILoggerClient logger = LogManager.GetCurrentLogInstance();
logger.Info("Log info");
```

</body>

