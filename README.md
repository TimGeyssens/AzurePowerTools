# Basic authentication for Windows Azure websites
Basic authentication for Windows Azure websites is a HTTP managed module that provides basic authentication for web applications hosted in Windows Azure websites. 

Forked and modified from https://github.com/devbridge/AzurePowerTools

To disable you can set a app setting

	<add key="BasicAuthEnabled" value="false"/>

Allows you to specify a IP whitelist and doesn't require auth when running local

    <basicAuth>
  		<credentials>
    		<add username="test" password="test"/>
  		</credentials>
  		<whitelist>
    		<add ip="78.21.79.247" />
  		</whitelist>
	</basicAuth>

Available through nuget

	Install-Package Nibble.Azure.BasicAuthentication


