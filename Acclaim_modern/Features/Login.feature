Feature:1Login
	Login with different credentials

	<B>Mockups</B>
![screenshot](https://dev.azure.com/InsurIQ/c280b3f7-9ae4-45a2-b5fe-9132ba656c59/_apis/wit/attachments/6a0442cd-fa12-437c-b9a0-aa00bea5170f?fileName=login%20page.PNG)
 ![screenshot](https://dev.azure.com/InsurIQ/c280b3f7-9ae4-45a2-b5fe-9132ba656c59/_apis/wit/attachments/6f567b0b-834e-44ab-b27f-f801641c4a6a?fileName=wrong%20userid.PNG)
@WI312

Scenario: 1 Login with wrong credentials
And go to this url "https://zrtest.qwikcoverage.com/login/login.aspx"
And enter username and password
And I enter as below
 | username | password |
 | admin    | pass     |
 And the user should stay on the same login screen.

 @WI312
 Scenario:2 Login with right username and wrong password
 And go to this url "https://zrtest.qwikcoverage.com/login/login.aspx"
 And enter username and password
 And I enter as below
 | username      | password |
 | Administrator | pass     |
 And the user should stay on the same login screen.
 @WI312
 Scenario:3 Login with right password and wrong username
 And go to this url "https://zrtest.qwikcoverage.com/login/login.aspx"
 And enter username and password
 And I enter as below
 | username      | password |
 | Administrator| p@SSWO1234      |
 And the user should stay on the same login screen.

 @WI312
Scenario:5 Login screen with right data
And go to this url "https://zrtest.qwikcoverage.com/login/login.aspx"
And enter username and password
And I enter as below
| username      | password     |
| Administrator | p@SSWORD1234 |
And the user should land on page titles "Dashboard"