### Description ###
The Constants class contains all the strings used to create the url for each api call.

### Loading local xml files during development ###
While developing your app you should have the api load response xml files from a local web server instead of hitting the eve api

```
// Put this code in your application startup
#if USE_LOCALHOST
Constants.ApiPrefix = "http://localhost/eveapi";
#endif
```

| Name | Default Value | Description |
|:-----|:--------------|:------------|
| ApiPrefix | "http://api.eve-online.com" | The base of all api urls. The other strings are concatenated with this string. |
| CharacterAccountBalance | "/char/AccountBalance.xml.aspx" | AccountBalances |
| CorpAccountBalance | "/corp/AccountBalance.xml.aspx" | AccountBalances |
| CharacterList | "/account/!Characters.xml.aspx" | CharacterList |
| StarbaseDetail | "/corp/StarbaseDetail.xml.aspx" | StarbaseDetail |
| StarbaseList | "/corp/StarbaseList.xml.aspx" | StarbaseList |
| ErrorList | "/eve/ErrorList.xml.aspx" | ErrorList |
| CharAssetList | "/char/AssetList.xml.aspx" | AssetList |
| CorpAssetList | "/corp/AssetList.xml.aspx" | AssetList |
| CharIndustryJobs | "/char/IndustryJobs.xml.aspx" | Science and Industry Jobs |
| CorpIndustryJobs | "/corp/IndustryJobs.xml.aspx" | Science and Industry Jobs |
| CharJournalEntries | "/char/JournalEntries.xml.aspx" | Journal Entries |
| CorpJournalEntries | "/corp/JournalEntries.xml.aspx" | Journal Entries |
| CharMarketTransactions | "/char/WalletTransactions.xml.aspx" | Market Transactions |
| CorpMarketTransactions | "/corp/WalletTransactions.xml.aspx" | Market Transactions |
| CharMarketOrders | "/char/MarketOrders.xml.aspx" | Market Orders |
| CorpMarketOrders | "/corp/MarketOrders.xml.aspx" | Market Orders |
| RefTypesList | "/eve/RefTypes.xml.aspx" | Reference Types for Journal Enteries |
| MemberTracking | "/corp/MemberTracking.xml.aspx" | Member Tracking |
| CharacterIDName | "/eve/CharacterID.xml.aspx" | Character ID / Name Translation |