# Flight-Aware-Demo

## env. setting
1. Visual Studio 2013
2. .Net Framework 4.5
3. Import FlightXML2 wsdl with "Add Service Reference ..." feature
4. Have to modify App.config / Web.config

## running step
1. Change MyUserName / MyPassword as your actual name/pwd which get from FlightAware
2. Check binding setting in App.config / Web.config, there should be a section, which enable Http Authentication when POST a request to FlightAware
```xml
<security mode="Transport">
  <transport clientCredentialType="Basic" />
</security>
```

## additional tools
1. Fiddler

  Capture http packet for SOAP / XML content checking
  

## reference
1. https://flightaware.com/commercial/flightxml/key  

  API key generation


