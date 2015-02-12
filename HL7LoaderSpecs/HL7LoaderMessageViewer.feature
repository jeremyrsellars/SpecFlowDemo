Feature: HL7Loader Message Viewer
  In order to see and understand HL7 (v2, v3, HL7v2-like) messages
  As an interfaces specialist
  I want to be able to see messages from ComChannels, ESI Logs, and flat files
  And I want the system to automatically detect the format of the message and select the appropriate viewer

Scenario: Displaying an HL7v2 message
  Given I am logged in as "InterfaceManager"
  And I load messages from hl7v2-test-messages.hl7
  When first loaded
  Then The first message should be displayed
  And The ViewerMode radio buttons should be set to HL7v2

Scenario: Displaying an HL7v3 message
  Given I am logged in as "InterfaceManager"
  And I load messages from hl7v3-test-messages.hl7
  And My default CDA is test.xsl
  When first loaded
  Then The first message should be displayed
  And The ViewerMode radio buttons should be set to HL7v3
  And a web browser should display the hl7 message according with test.xsl

Scenario: Autodetect the viewer mode when switching between messages
  Given I am logged in as "InterfaceManager"
  And I load messages from hl7mixed-test-messages.hl7
  When I select an HL7v3 message
  And I select an HL7v2 message
  And The ViewerMode radio buttons should be set to HL7v2
