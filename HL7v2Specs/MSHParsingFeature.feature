Feature: Graceful MSH-parsing
  In order to gracefully handle HL7v2 messages with an MSH that is not quite up to the HL7v2 spec
  As a troubleshooter who doesn't care about whether the message actually matches the spec
  I want to see the parts of message as if it was correctly specified - it should fail gracefully,
  So that I can see a better representation of the message than the raw text.


Scenario: MSH may be absent altogether
  Given The message: "FIN|1|2|3|4"
  Then Should be interpreted as MSH|^~\&\|

Scenario: Access to Financial messages must be audited
  Given Joan accessed a message containing "FIN|1|2|mrn-goes-here|4"
  Then There should be a related audit record
  And The a record should say Joan did it
  And The record should be attached to patient mrn-goes-here
  And The audit record should be timestamped with the current time.

Scenario Outline: MSH2 may be incomplete
  Given A message starting with <ActualMSH>
  Then Should be interpreted as <InterpretedMSH>
  And Should be <Validity> because <Reason>

  Examples:
    | ActualMSH   | InterpretedMSH | Validity | Reason                                                      |
    | MSH\|^~\&\| | MSH\|^~\&\|    | valid    | fully-specified                                             |
    | MSH\|^~\\|  | MSH\|^~\&\|    | valid    | everything is optional                                      |
    | MSH\|^~\|   | MSH\|^~\&\|    | valid    | everything is optional                                      |
    | MSH\|^\|    | MSH\|^~\&\|    | valid    | everything is optional                                      |
    | MSH\|\|     | MSH\|^~\&\|    | valid    | everything is optional                                      |
    | MSH\|       | MSH\|^~\&\|    | valid    | everything is optional                                      |
    | MSH         | MSH\|^~\&\|    | valid    | everything is optional                                      |
    | MSH?^~\&?   | MSH?^~\&?      | valid    | fully-specified                                             |
    | MSH?^~\?    | MSH?^~\&?      | valid    | everything is optional                                      |
    | MSH?^~?     | MSH?^~\&?      | valid    | everything is optional                                      |
    | MSH?^?      | MSH?^~\&?      | valid    | everything is optional                                      |
    | MSH??       | MSH?^~\&?      | valid    | MSH.2 is empty                                              |
    | MSH?????    | MSH?^~\&?      | valid    | MSH.2 is empty                                              |
    | MSH?        | MSH?^~\&?      | valid    | everything is optional                                      |
    | MSH?^^?     | MSH?^^\&?      | invalid  | component separator may not equal field repeat separator    |
    | MSH?^~~?    | MSH?^~~&?      | invalid  | field repeat separator may not equal escape separator       |
    | MSH?^~\~?   | MSH?^~\~?      | invalid  | field repeat separator may not equal subcomponent separator |
    | MSH$        | MSH$^~\&$      | valid    |                                                             |
