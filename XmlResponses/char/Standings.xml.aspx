<?xml version='1.0' encoding='UTF-8'?>
<eveapi version="2">
  <currentTime>2008-09-03 12:20:19</currentTime>
  <result>
    <standingsTo>
      <rowset name="characters" key="toID" columns="toID,toName,standing">
        <row toID="123456" toName="Test Ally" standing="1" />
        <row toID="234567" toName="Test Friend" standing="0.5" />
        <row toID="345678" toName="Test Enemy" standing="-0.8" />
      </rowset>
      <rowset name="corporations" key="toID" columns="toID,toName,standing">
        <row toID="456789" toName="Test Bad Guy Corp" standing="-1" />
      </rowset>
    </standingsTo>
    <standingsFrom>
      <rowset name="agents" key="fromID" columns="fromID,fromName,standing">
        <row fromID="3009841" fromName="Pausent Ansin" standing="0.1" />
        <row fromID="3009846" fromName="Charie Octienne" standing="0.19" />
      </rowset>
      <rowset name="NPCCorporations" key="fromID" columns="fromID,fromName,standing">
        <row fromID="1000061" fromName="Freedom Extension" standing="0" />
        <row fromID="1000064" fromName="Carthum Conglomerate" standing="0.34" />
        <row fromID="1000094" fromName="TransStellar Shipping" standing="0.02" />
      </rowset>
      <rowset name="factions" key="fromID" columns="fromID,fromName,standing">
        <row fromID="500003" fromName="Amarr Empire" standing="-0.1" />
        <row fromID="500020" fromName="Serpentis" standing="-1" />
      </rowset>
    </standingsFrom>
  </result>
  <cachedUntil>2008-09-03 15:20:19</cachedUntil>
</eveapi>
