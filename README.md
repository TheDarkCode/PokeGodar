###Cups of coffee donated: :coffee:

# PokeGodar
###Status: Not Building - yet. Subroutines, Layouts, etc, still being added.
Sample project in C# and Swift 3 to demonstrate building a comprehensive Pokemon Go Radar / Bot with backend which can be scaled to accomodate any level of traffic. This project is sponsored by [Dryverless, Inc.](http://www.dryverless.com) and is a non-commercial project covered by fair use exemption for the purposes of research and commentary.

####Planned Features
  - PTC and Google Authentication
  - Heartbeat / Autowalking
  - Pokestop / Gym Farming
  - Auto-catch Pokemon
  - Evolve Pokemon
  - Transfer Pokemon
  - Use Lucky Eggs
  - Use Incense
  - Use Best Pokeball or Berry
  - Cloud-based Botting
  - Data Export / Mining via Azure ML

This repo, when complete, will contain a sample full application (client and back-end in separate projects) that demonstrates using Swift 3 for iOS 10 with a ASP.NET 4.6.x Web API on Azure using DocumentDB and Azure Search. Swift 2.x support is handled via iOS 9.x MobileApp project.

Real-time support is handled via websockets and SignalR for the purposes of demonstration. If you choose to use a backplane, you should be aware of latency or cost issues that might be incurred.

### Current API Methods List

#### Bot Utils

- [ ] Farm Pokestops and Pokemon (Auto Play Enabled)

#### Player Utils

- [x] Get Profile
- [x] Get Settings
- [x] Get Best Ball
- [x] Recycle Item
- [x] Get Items
- [x] Get Inventory
- [x] Use Capture Items
- [x] UseRazzBerry
- [x] Use Item XP Boost
- [ ] Update Player Location
- [ ] Get Xp Differential
- [ ] Get Total Pokemon
- [ ] Get Total Experience
- [ ] Get Current Level

#### Pokemon Utils

- [x] Catch Pokemon
- [x] Encounter Pokemon
- [x] Transfer Pokemon
- [x] Evolve Pokemon
- [ ] Evolve All Given Pokemon
- [ ] Catch All Nearby Pokemon
- [ ] Transfer All But Strongest Unwanted Pokemon
- [ ] Transfer All Given Pokemon
- [ ] Transfer Duplicate Pokemon
- [ ] Transfer All Weak Pokemon
- [ ] Calculate Perfect

#### Map Utils

- [ ] Get Map Objects

#### Fort Utils

- [x] Get Fort
- [x] Search Fort

#### Login Utils

- [ ] Do Ptc Login
- [ ] Do Google Login
    - [ ] Do Google OAuth Login
    - [ ] Get Access Token?


<hr />

####If you looking for a fully-supported development framework for quickly launching mobile applications, inquire via e-mail: [sales@dryverless.com](mailto:sales@dryverless.com?Subject=Ahtau Sales). Ask for a license to use the Ahtau Framework.

####If you are an Advertiser or Publisher looking to increase payouts, lead generation, or explore new monetization strategies, sign up at [DryverlessAds.com](http://www.dryverlessads.com).

<hr />

####Azure Service Requirements for Deployment

You must configure the project with your own Azure Search Keys, Azure DocumentDB Database Connection Information, and Bing Maps API Keys.

######If you are new to Azure, you can get a free trial at the following link: 
https://azure.microsoft.com/en-us/pricing/free-trial/

######Bing Maps API (10k transactions/mo for free)
http://www.microsoft.com/maps/Licensing/licensing.aspx#mainTab2

######Azure Search Service are free excluding outbound data transfers (3 data connections / indexes / indexers, 50 MB Total Storage, 10,000 Documents).
https://azure.microsoft.com/en-us/pricing/details/search/

######Azure DocumentDB requires at least an S1 plan ($25/mo = 250 RU/sec, 10 GB Storage) for each collection used (even empty ones).
https://azure.microsoft.com/en-us/pricing/details/documentdb/

######Data Transfers Pricing Details
https://azure.microsoft.com/en-us/pricing/details/data-transfers/

#####How User Data Appears on DocDB Server:
```json
{
  "id": "463b5add-3abb-482c-8f72-9f199203e22b",
  "UserName": "demo@github.com",
  "Email": "demo@github.com",
  "EmailConfirmed": true,
  "PasswordHash": "AMZO39oQGu9eUtMcy8gho6oPxETXQ8OPmeju7JEVMeHW7LgQi/hcnEATX7294xfBKg==",
  "SecurityStamp": "31a3e067-7508-41c4-acd5-d4311da67b2c",
  "PhoneNumber": null,
  "PhoneNumberConfirmed": false,
  "TwoFactorEnabled": false,
  "LockoutEnd": "0001-01-01T00:00:00+00:00",
  "LockoutEnabled": false,
  "AccessFailedCount": 0,
  "Logins": [],
  "Claims": [],
  "Roles": []
}
```

##Related GitHub Projects / Credits

###pgoapi-swift by Luke Sapan
######https://github.com/lsapan/pgoapi-swift

###pgoapi by tejado
######https://github.com/tejado/pgoapi

###POGOProtos by AeonLucid
######https://github.com/AeonLucid/POGOProtos

###Example Swift Apps by Mark Hamilton, Dryverless
######https://github.com/TheDarkCode/Example-Swift-Apps

###AngularAzureSearch by Mark Hamilton, Dryverless
######https://github.com/TheDarkCode/AngularAzureSearch/

###Azure Search Demos by Liam Cavanagh, Microsoft
######https://github.com/liamca/AzureSearchDemos
######http://azure.microsoft.com/en-us/documentation/services/search/

###DocumentDb with Web API by Richard J. Leopold
######https://github.com/rleopold/DocDbWebApi/
######(Article found here: http://4rjl.net/post/azure-documentdb-with-web-api)

###DocumentDB.AspNet.Identity by Adrian Fernandez, Microsoft
######https://github.com/tracker086/DocumentDB.AspNet.Identity

###GolfTracker.DocumentDB by King Wilder, Gizmo Beach
######https://github.com/kahanu/GolfTracker.DocumentDB/
######(Video / Article Series found here: http://www.nosqlcentral.net/Story/Details/videos/kahanu/1-documentdb-golf-tracker-overview)

###azure-documentdb-dotnet by Ryan CrawCour & Aravind Ramachandran, Microsoft
######https://github.com/Azure/azure-documentdb-dotnet/
######(Article found here: https://azure.microsoft.com/en-us/documentation/articles/documentdb-sharding/)

###MailService by James Bisiar
######https://github.com/bisiar

###MVA-SignalR by Jon Galloway & Brady Gaster, Microsoft
######https://github.com/jongalloway/MVA-SignalR

##Helpful Links

######http://blogs.msdn.com/b/documentdb/archive/2014/12/03/scaling-a-multi-tenant-application-with-azure-documentdb.aspx
######DocumentDB Documentation: https://msdn.microsoft.com/en-us/library/azure/dn781482.aspx
######Azure Search Documentation: https://msdn.microsoft.com/en-us/library/azure/dn798933.aspx
######W3C Recommendation on Cross-Origin-Resource-Sharing: http://www.w3.org/TR/cors/

##Related Microsoft Virtual Academy Courses

####Adding Microsoft Azure Search to Your Websites and Apps:
######https://mva.microsoft.com/en-us/training-courses/adding-microsoft-azure-search-to-your-websites-and-apps-10540

####Developing Solutions with Azure DocumentDB:
######https://mva.microsoft.com/en-us/training-courses/developing-solutions-with-azure-documentdb-10554

####Lighting Up Real-Time Web Communications with SignalR:
######https://mva.microsoft.com/en-us/training-courses/lighting-up-real-time-web-communications-with-signalr-8358

##Support:

#####Send any questions or requests to: support@dryverless.com

## Contributing

  - 1) Fork this repository!
  - 2) Create your feature branch: ```git checkout -b Your-New-Feature```
  - 3) Commit your changes: ```git commit -am 'Adding some super awesome update'```
  - 4) Push to the branch: ```git push origin Your-New-Feature```
  - 5) Submit a pull request!
  
####Alternatively, if you want to buy coffee to get more done, you can do so here: https://www.paypal.me/dryverless

## License
Copyright (c) 2016 Mark Hamilton / dryverless (http://www.dryverless.com)

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
