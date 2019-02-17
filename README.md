Log2log is a logger for >= .Net Framework 4.5

Please, add this settings in your App/Web.config

<configSections>
    <section name="log2log" type="log2log.Configuration.LogConfigSection, log2log "/>
</configSections>

<log2log>
    <settings>
      <setting name="log2log" path="Log\LogFile.txt" levelFilter="false"/>
    </settings>
</log2log>

<p>
<em>
<strong>Name</strong> is just a name of logger.
<strong>Path</strong> is the path of create a .log file with/without subdirectory (By default, the .log is creates in the main directory of project)
<strong>LevelFilter</strong> is enables or disables filtering by level. (Now is not available)
</em>
</p>
