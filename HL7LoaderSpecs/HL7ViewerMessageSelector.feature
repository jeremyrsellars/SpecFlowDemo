Feature: HL7Loader Message Selector
  In order to see and understand HL7 (v2, v3, HL7v2-like) messages
  As an interfaces specialist
  I want to be able to see messages from ComChannels, ESI Logs, and flat files.

Scenario: Loading messages from an Outbound ComChannel
  Given I am logged in as "InterfaceManager"
  And I have selected "Load from ComChannel"
  And I have picked "rscnADToutbound"
  And There are 20 messages from randomMessageGenerator
  When I press Load
  Then There should be 20 messages to select from
  And The next page button should be disabled
  And The previous page button should be disabled
  And A LoadedHL7 audit record should be written for rscnADToutbound for the current time































#Scenario: Loading messages from an Outbound ComChannel
#  Given I am logged in as "InterfaceManager"
#  And I have selected "Load from ComChannel"
#  And I have picked "rscnADToutbound"
#  And There are 200 messages from randomMessageGenerator
#  When I press Load
#  Then There should be 100 messages to select from
#  And The next page button should be enabled
#  And The previous page button should be disabled
#  And A LoadedHL7 audit record should be written for rscnADToutbound for the current time




























#Scenario Outline: Loading messages from a ComChannel
#  Given I am logged in as "InterfaceManager"
#  And I have selected "Load from ComChannel"
#  And I have picked "rscnADToutbound"
#  And There are <Message Count> messages from randomMessageGenerator
#  And Messages to load is set to <Messages to load>
#  When I press Load
#  Then There should be <Displayed Count> messages to select from
#  And The next page button should be <Next Page Button>
#  And A LoadedHL7 audit record should be written for rscnADToutbound for the current time
#
#  Examples:
#    | Message Count | Messages to load | Displayed Count | Next Page Button |
#    | 0             | 100              | 0               | disabled         |
#    | 99            | 100              | 99              | disabled         |
#    | 100           | 100              | 100             | enabled          |
#    | 11            | 10               | 10              | enabled          |
