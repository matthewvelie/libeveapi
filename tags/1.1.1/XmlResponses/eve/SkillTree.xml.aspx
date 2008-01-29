<?xml version='1.0' encoding='UTF-8'?>
<eveapi version="2">
  <currentTime>2008-01-16 00:36:57</currentTime>
  <result>
    <rowset name="skillGroups" key="groupID" columns="groupName,groupID">
      <row groupName="Corporation Management" groupID="266">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Anchoring" groupID="266" typeID="11584">
            <description>Skill at Anchoring Deployables. Can not be trained on Trial Accounts.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="CFO Training" groupID="266" typeID="3369">
            <description>Skill at managing corp finances. 5% discount on all fees at non-hostile NPC station if acting as CFO of a corp. </description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3363" skillLevel="2" />
              <row typeID="3444" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Corporation Management" groupID="266" typeID="3363">
            <description>Basic corporation operation. +10 corporation members allowed per level.

Notice:  the CEO must update his corporation through the corporation user interface before the skill takes effect</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="corporationMemberBonus" bonusValue="10" />
            </rowset>
          </row>
          <row typeName="Empire Control" groupID="266" typeID="3732">
            <description>Advanced corporation operation. +200 corporation members allowed per level. 

Notice:  the CEO must update his corporation through the corporation user interface before the skill takes effect</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3731" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="corporationMemberBonus" bonusValue="200" />
            </rowset>
          </row>
          <row typeName="Ethnic Relations" groupID="266" typeID="3368">
            <description>Skill at operating multiracial corporations. Extra 20% corporation members of other race than CEO allowed per skill level.  Percentage is based on CEO's corporation management skills, not the number of people in the corporation.

Note:  the CEO must update his corporation through the corporation user interface before the skill takes effect.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3363" skillLevel="2" />
              <row typeID="3355" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="nonRaceCorporationMembersBonus" bonusValue="20" />
            </rowset>
          </row>
          <row typeName="Megacorp Management" groupID="266" typeID="3731">
            <description>Advanced corporation operation. +50 members per level.

Notice:  the CEO must update his corporation through the corporation user interface before the skill takes effect</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3363" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="corporationMemberBonus" bonusValue="50" />
            </rowset>
          </row>
          <row typeName="Sovereignty" groupID="266" typeID="12241">
            <description>Advanced corporation operation. +1000 corporation members allowed per level. 

Notice:  the CEO must update his corporation through the corporation user interface before the skill takes effect</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3732" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="corporationMemberBonus" bonusValue="1000" />
            </rowset>
          </row>
          <row typeName="Starbase Defense Management" groupID="266" typeID="3373">
            <description>Skill at using starbase weapon systems. Allows control of one array per level. Arrays must be placed outside of the forcefield to be controlled. 

Can not be trained on Trial Accounts.

</description>
            <rank>7</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="11584" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
              <row bonusType="posStructureControlAmount" bonusValue="0" />
            </rowset>
          </row>
        </rowset>
      </row>
      <row groupName="Drones" groupID="273">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Advanced Drone Interfacing" groupID="273" typeID="24613">
            <description>Allows the use of the Drone Control Unit module. One extra module can be fitted per skill level. Each fitted Drone Control Unit allows the operation of one extra drone.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3442" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Amarr Drone Specialization" groupID="273" typeID="12484">
            <description>Specialization in the operation of advanced Amarr drones. 2% bonus to advanced Amarr drone damage per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Caldari Drone Specialization" groupID="273" typeID="12487">
            <description>Specialization in the operation of advanced Caldari drones. 2% bonus to advanced Caldari drone damage per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Combat Drone Operation" groupID="273" typeID="24241">
            <description>Skill at controlling scout drones. 5% Bonus to drone damage of light and medium drones per level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Drone Durability" groupID="273" typeID="23618">
            <description>Increases drone hit points. 5% bonus to drone shield, armor and hull hit points per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="hullHpBonus" bonusValue="5" />
              <row bonusType="armorHpBonus" bonusValue="5" />
              <row bonusType="shieldCapacityBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Drone Interfacing" groupID="273" typeID="3442">
            <description>Allows a captain to better maintain its drones. 20% bonus to drone damage, drone mining yield per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="20" />
              <row bonusType="miningAmountBonus" bonusValue="20" />
            </rowset>
          </row>
          <row typeName="Drone Navigation" groupID="273" typeID="12305">
            <description>Increases drone max velocity.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="droneMaxVelocityBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Drone Sharpshooting" groupID="273" typeID="23606">
            <description>Increases drone optimal range.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rangeSkillBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Drones" groupID="273" typeID="3436">
            <description>Skill at remote controlling drones. Can operate 1 drone per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="maxActiveDroneBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Electronic Warfare Drone Interfacing" groupID="273" typeID="23566">
            <description>Allows operation of electronic warfare drones. 3000m drone control range bonus per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="5" />
              <row typeID="3427" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="droneRangeBonus" bonusValue="3000" />
            </rowset>
          </row>
          <row typeName="Fighters" groupID="273" typeID="23069">
            <description>Allows operation of fighter drones. 20% increase in fighter damage per level.</description>
            <rank>12</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3442" skillLevel="5" />
              <row typeID="3348" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="20" />
            </rowset>
          </row>
          <row typeName="Gallente Drone Specialization" groupID="273" typeID="12486">
            <description>Specialization in the operation of advanced Gallente drones. 2% bonus to advanced Gallente drone damage per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Heavy Drone Operation" groupID="273" typeID="3441">
            <description>Skill at controlling heavy combat drones. 5% Bonus to heavy drone damage per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Mining Drone Operation" groupID="273" typeID="3438">
            <description>Skill at controlling mining drones. 5% Bonus to mining drone yield per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="1" />
              <row typeID="3386" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="miningAmountBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Minmatar Drone Specialization" groupID="273" typeID="12485">
            <description>Specialization in the operation of advanced Minmatar drones. 2% bonus to advanced Minmatar drone damage per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Repair Drone Operation" groupID="273" typeID="3439">
            <description>Allows operation of logistic drones. 5% increased repair amount per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="5" />
              <row typeID="23618" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageHP" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Scout Drone Operation" groupID="273" typeID="3437">
            <description>Skill at controlling scout combat drones.

Bonus: drone control range increased by 5000 meters per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3436" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="droneRangeBonus" bonusValue="5000" />
            </rowset>
          </row>
          <row typeName="Sentry Drone Interfacing" groupID="273" typeID="23594">
            <description>Skill at controlling sentry drones.  5% bonus to Sentry Drone damage per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3442" skillLevel="4" />
              <row typeID="23606" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
        </rowset>
      </row>
      <row groupName="Electronics" groupID="272">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Cloaking" groupID="272" typeID="11579">
            <description>Skill at using Cloaking devices. 10% per level reduction in targeting delay after uncloaking per skill level. Can not be trained on Trial Accounts.</description>
            <rank>6</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="cloakingTargetingDelayBonus" bonusValue="-10" />
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Cynosural Field Theory" groupID="272" typeID="21603">
            <description>Skill at creating effective cynosural fields. 10% reduction in liquid ozone consumption for module activation per skill level. Can not be trained on Trial Accounts.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
              <row bonusType="consumptionQuantityBonusPercentage" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Electronic Warfare" groupID="272" typeID="3427">
            <description>Operation of ECM jamming systems. 5% less capacitor need for ECM and ECM Burst systems per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Electronics" groupID="272" typeID="3426">
            <description>Basic understanding of spaceship sensory and computer systems. 5% Bonus to ship CPU output per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="cpuOutputBonus2" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Electronics Upgrades" groupID="272" typeID="3432">
            <description>Skill at installing Electronic upgrades, e.g. signal amplifier, Co-Processors and backup sensor array. 5% reduction of sensor upgrade CPU needs per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="2" />
              <row typeID="3413" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="cpuNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Frequency Modulation" groupID="272" typeID="19760">
            <description>Advanced understanding of signal waves. 10% bonus to falloff for ECM, Remote Sensor Dampeners, Tracking Disruptors and Target Painters per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="3" />
              <row typeID="3427" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="falloffBonus" bonusValue="10" />
            </rowset>
          </row>
          <row typeName="Long Distance Jamming" groupID="272" typeID="19759">
            <description>Skill at the long-range operation of electronic warfare systems.  10% bonus to optimal range of ECM, Remote Sensor Dampers, Tracking Disruptors and Target Painters per skill level.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="4" />
              <row typeID="3427" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rangeSkillBonus" bonusValue="10" />
            </rowset>
          </row>
          <row typeName="Long Range Targeting" groupID="272" typeID="3428">
            <description>Skill at long range targeting. 5% Bonus to targeting range per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="maxTargetRangeBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Multitasking" groupID="272" typeID="3430">
            <description>Skill at targeting multiple targets. +1 extra target per skill level, up to the ship's maximum allowed number of targets locked.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3429" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="maxTargetBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Projected Electronic Counter Measures" groupID="272" typeID="27911">
            <description>Operation of projected ECM jamming systems. Each skill level gives 5% less delay between module activation and ECM burst effect.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3427" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="projECMDurationBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Propulsion Jamming" groupID="272" typeID="3435">
            <description>Skill at using propulsion/warpdrive jammers. 5% Reduction to warp scrambler and stasis web capacitor need per skill level. </description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="3" />
              <row typeID="3449" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Sensor Linking" groupID="272" typeID="3433">
            <description>Skill at using remote sensor booster/damper. 5% less capacitor need for sensor link per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Signal Dispersion" groupID="272" typeID="19761">
            <description>Skill at the operation of target jamming equipment.  5% bonus to strength of all ECM jammers per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="5" />
              <row typeID="3427" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="scanSkillEwStrengthBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Signal Suppression" groupID="272" typeID="19766">
            <description>Skill at the operation of remote sensor dampers.  5% bonus to remote sensor dampers' scan resolution and targeting range suppression per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="5" />
              <row typeID="3433" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="scanSkillEwStrengthBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Signature Analysis" groupID="272" typeID="3431">
            <description>Skill at operating Targeting systems. 5% improved targeting speed per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="scanResolutionBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Signature Focusing" groupID="272" typeID="19922">
            <description>Advanced understanding of target painting technology. 5% bonus to target painter modules' signature radius multiplier per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="5" />
              <row typeID="19921" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="scanSkillTargetPaintStrengthBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Survey" groupID="272" typeID="3551">
            <description>Skill at operating scanners. 5% improvement in scanner speeds per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="scanspeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Target Painting" groupID="272" typeID="19921">
            <description>Skill at using target painters. 5% less capacitor need for target painters per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Targeting" groupID="272" typeID="3429">
            <description>Skill at targeting multiple targets. +1 extra target per skill level, up to the ship's maximum allowed number of targets locked.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="maxTargetBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Turret Destabilization" groupID="272" typeID="19767">
            <description>Advanced understanding of tracking disruption technology.  5% bonus to Tracking Disruptor modules' tracking speed and optimal range disruption per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="5" />
              <row typeID="3434" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="scanSkillEwStrengthBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Weapon Disruption" groupID="272" typeID="3434">
            <description>Skill at using remote weapon disruptors. 5% less capacitor need for weapon disruptors per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3426" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
        </rowset>
      </row>
      <row groupName="Engineering" groupID="271">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Capital Energy Emission Systems" groupID="271" typeID="24572">
            <description>Operation of capital sized energy transfer array and other energy emission systems. 5% reduced capacitor need of capital energy emission systems per skill level.</description>
            <rank>10</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="5" />
              <row typeID="3423" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Capital Shield Emission Systems" groupID="271" typeID="24571">
            <description>Operation of capital sized shield transfer array and other shield emission systems. 5% reduced capacitor need for capital shield emission system modules per skill level.</description>
            <rank>10</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="5" />
              <row typeID="3422" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Capital Shield Operation" groupID="271" typeID="21802">
            <description>Operation of capital shield boosters and other shield modules. 2% reduction in capacitor need for capital shield boosters per skill level.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3420" skillLevel="5" />
              <row typeID="3416" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="shieldBoostCapacitorBonus" bonusValue="-2" />
            </rowset>
          </row>
          <row typeName="EM Shield Compensation" groupID="271" typeID="12365">
            <description>To active shield hardeners: 3% bonus per skill level to Shield EM resistance when the modules are not active 
To passive shield hardeners: 5% bonus per skill level to Shield EM resistance</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3416" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="hardeningBonus" bonusValue="5" />
              <row bonusType="hardeningbonus2" bonusValue="3" />
            </rowset>
          </row>
          <row typeName="Energy Emission Systems" groupID="271" typeID="3423">
            <description>Operation of energy transfer array and other energy emission systems. 5% reduced capacitor need of energy emission weapons per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="3" />
              <row typeID="3402" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Energy Grid Upgrades" groupID="271" typeID="3424">
            <description>Skill at installing power upgrades e.g. capacitor battery and power diagnostic units. 5% reduction in CPU needs of modules requiring Energy Grid Upgrades per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="2" />
              <row typeID="3402" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="cpuNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Energy Management" groupID="271" typeID="3418">
            <description>Skill at regulating your ship's overall energy capacity. 5% bonus to capacitor capacity per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capacitorCapacityBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Energy Pulse Weapons" groupID="271" typeID="3421">
            <description>Skill at using smartbombs. 5% decrease in smartbomb duration per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="2" />
              <row typeID="3402" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="durationBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Energy Systems Operation" groupID="271" typeID="3417">
            <description>Skill at operating your ship's capacitor, including the use of capacitor boosters and other basic energy modules. 5% reduction in capacitor recharge time per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capRechargeBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Engineering" groupID="271" typeID="3413">
            <description>Basic understanding of spaceship energy grid systems. 5% Bonus to ship's powergrid output per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="powerEngineeringOutputBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Explosive Shield Compensation" groupID="271" typeID="12367">
            <description>To active shield hardeners: 3% bonus per skill level to Shield Explosive resistance when the modules are not active
To passive shield hardeners: 5% bonus per skill level to Shield Explosive resistance</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3416" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="resistanceBonus" bonusValue="0" />
              <row bonusType="hardeningBonus" bonusValue="5" />
              <row bonusType="hardeningbonus2" bonusValue="3" />
            </rowset>
          </row>
          <row typeName="Kinetic Shield Compensation" groupID="271" typeID="12366">
            <description>To active shield hardeners: 3% bonus per skill level to Shield Kinetic resistance when the modules are not active
To passive shield hardeners: 5% bonus per skill level to Shield Kinetic resistance</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3416" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="resistanceBonus" bonusValue="0" />
              <row bonusType="hardeningBonus" bonusValue="5" />
              <row bonusType="hardeningbonus2" bonusValue="3" />
            </rowset>
          </row>
          <row typeName="Shield Compensation" groupID="271" typeID="21059">
            <description>Improved skill for regulating energy flow to shields. 2% less capacitor need for shield boosters per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3416" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="shieldBoostCapacitorBonus" bonusValue="-2" />
            </rowset>
          </row>
          <row typeName="Shield Emission Systems" groupID="271" typeID="3422">
            <description>Operation of shield transfer array and other shield emission systems. 5% reduced capacitor need for shield emission system modules per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="3" />
              <row typeID="3402" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Shield Management" groupID="271" typeID="3419">
            <description>Skill at regulating a spaceship's shield systems.  5% bonus to shield capacity per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="shieldCapacityBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Shield Operation" groupID="271" typeID="3416">
            <description>Skill at operating a spaceship's shield systems, including the use of shield boosters and other basic shield modules.  5% reduction in shield recharge time per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rechargeratebonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Shield Upgrades" groupID="271" typeID="3425">
            <description>Skill at installing shield upgrades e.g. shield extenders and shield rechargers. 5% reduction in shield upgrade powergrid needs.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="2" />
              <row typeID="3402" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="powerNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Tactical Shield Manipulation" groupID="271" typeID="3420">
            <description>Skill at preventing damage from penetrating the shield, including the use of shield hardeners and other advanced shield modules.  Reduces the chance of damage penetrating the shield when it falls below 25% by 5% per skill level, with 0% chance at level 5.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="uniformityBonus" bonusValue="0.05" />
            </rowset>
          </row>
          <row typeName="Thermic Shield Compensation" groupID="271" typeID="11566">
            <description>To active shield hardeners: 3% bonus per skill level to Shield Thermal resistance when the modules are not active
To passive shield hardeners: 5% bonus per skill level to Shield Thermal resistance</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3416" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="resistanceBonus" bonusValue="0" />
              <row bonusType="hardeningBonus" bonusValue="5" />
              <row bonusType="hardeningbonus2" bonusValue="3" />
            </rowset>
          </row>
        </rowset>
      </row>
      <row groupName="Gunnery" groupID="255">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Advanced Weapon Upgrades" groupID="255" typeID="11207">
            <description>Reduces the powergrid needs of weapon turrets and launchers by 2% per skill level.</description>
            <rank>6</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3318" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="powerNeedBonus" bonusValue="-2" />
            </rowset>
          </row>
          <row typeName="Capital Energy Turret" groupID="255" typeID="20327">
            <description>Operation of capital energy turrets. 5% Bonus to capital energy turret damage per level.</description>
            <rank>7</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="5" />
              <row typeID="3309" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Capital Hybrid Turret" groupID="255" typeID="21666">
            <description>Operation of capital hybrid turrets. 5% Bonus to capital hybrid turret damage per level.</description>
            <rank>7</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="5" />
              <row typeID="3307" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Capital Projectile Turret" groupID="255" typeID="21667">
            <description>Operation of capital projectile turrets. 5% Bonus to capital projectile turret damage per level.</description>
            <rank>7</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="5" />
              <row typeID="3308" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Controlled Bursts" groupID="255" typeID="3316">
            <description>Allows better control over the capacitor use of weapon turrets. 5% reduction in capacitor need of weapon turrets per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Gunnery" groupID="255" typeID="3300">
            <description>Basic turret operation skill. 2% Bonus to weapon turrets' rate of fire per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="turretSpeeBonus" bonusValue="-2" />
            </rowset>
          </row>
          <row typeName="Large Artillery Specialization" groupID="255" typeID="12203">
            <description>Specialist training in the operation of advanced Large Artillery.  2% bonus per skill level to the damage of large turrets requiring Large Artillery Specialization.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3311" skillLevel="5" />
              <row typeID="12202" skillLevel="4" />
              <row typeID="3308" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Large Autocannon Specialization" groupID="255" typeID="12209">
            <description>Specialist training in the operation of advanced large autocannons. 2% Bonus per skill level to the damage of large turrets requiring Large Autocannon Specialization.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3312" skillLevel="5" />
              <row typeID="12208" skillLevel="4" />
              <row typeID="3308" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Large Beam Laser Specialization" groupID="255" typeID="12205">
            <description>Specialist training in the operation of advanced large beam lasers. 2% Bonus per skill level to the damage of large turrets requiring Large Beam Laser Specialization.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3311" skillLevel="5" />
              <row typeID="12204" skillLevel="4" />
              <row typeID="3309" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Large Blaster Specialization" groupID="255" typeID="12212">
            <description>Specialist training in the operation of advanced large blasters. 2% Bonus per skill level to the damage of large turrets requiring Large Blaster Specialization.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3312" skillLevel="5" />
              <row typeID="12211" skillLevel="4" />
              <row typeID="3307" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Large Energy Turret" groupID="255" typeID="3309">
            <description>Operation of large energy turrets. 5% Bonus to large energy turret damage per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="5" />
              <row typeID="3306" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Large Hybrid Turret" groupID="255" typeID="3307">
            <description>Operation of large hybrid turret. 5% Bonus to large hybrid turret damage per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="5" />
              <row typeID="3304" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Large Projectile Turret" groupID="255" typeID="3308">
            <description>Operation of large projectile turret. 5% Bonus to large projectile turret damage per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="5" />
              <row typeID="3305" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Large Pulse Laser Specialization" groupID="255" typeID="12215">
            <description>Specialist training in the operation of advanced large pulse lasers. 2% bonus per skill level to the damage of large turrets requiring Large Pulse Laser Specialization.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3312" skillLevel="5" />
              <row typeID="12214" skillLevel="4" />
              <row typeID="3309" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Large Railgun Specialization" groupID="255" typeID="12207">
            <description>Specialist training in the operation of advanced large railguns. 2% bonus per skill level to the damage of large turrets requiring Large Railgun Specialization.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3311" skillLevel="5" />
              <row typeID="12206" skillLevel="4" />
              <row typeID="3307" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Medium Artillery Specialization" groupID="255" typeID="12202">
            <description>Specialist training in the operation of advanced Medium Artillery.  2% bonus per skill level to the damage of medium turrets requiring Medium Artillery Specialization.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3311" skillLevel="4" />
              <row typeID="12201" skillLevel="4" />
              <row typeID="3305" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Medium Autocannon Specialization" groupID="255" typeID="12208">
            <description>Specialist training in the operation of advanced medium autocannons. 2% bonus per skill level to the damage of medium turrets requiring Medium Autocannon Specialization.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3312" skillLevel="4" />
              <row typeID="11084" skillLevel="4" />
              <row typeID="3305" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Medium Beam Laser Specialization" groupID="255" typeID="12204">
            <description>Specialist training in the operation of advanced medium beam lasers. 2% bonus per skill level to the damage of medium turrets requiring Medium Beam Laser Specialization.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3311" skillLevel="4" />
              <row typeID="11083" skillLevel="4" />
              <row typeID="3306" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Medium Blaster Specialization" groupID="255" typeID="12211">
            <description>Specialist training in the operation of advanced medium blasters. 2% bonus per skill level to the damage of medium turrets requiring Medium Blaster Specialization.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3312" skillLevel="4" />
              <row typeID="12210" skillLevel="4" />
              <row typeID="3304" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Medium Energy Turret" groupID="255" typeID="3306">
            <description>Operation of medium energy turret. 5% Bonus to medium energy turret damage per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="3" />
              <row typeID="3303" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Medium Hybrid Turret" groupID="255" typeID="3304">
            <description>Operation of medium hybrid turrets. 5% Bonus to medium hybrid turret damage per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="3" />
              <row typeID="3301" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Medium Projectile Turret" groupID="255" typeID="3305">
            <description>Operation of medium projectile turrets. 5% Bonus to medium projectile turret damage per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="3" />
              <row typeID="3302" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Medium Pulse Laser Specialization" groupID="255" typeID="12214">
            <description>Specialist training in the operation of advanced medium pulse lasers. 2% bonus per skill level to the damage of medium turrets requiring Medium Pulse Laser Specialization.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3312" skillLevel="4" />
              <row typeID="12213" skillLevel="4" />
              <row typeID="3306" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Medium Railgun Specialization" groupID="255" typeID="12206">
            <description>Specialist training in the operation of advanced medium railguns. 2% bonus per skill level to the damage of medium turrets requiring Medium Railgun Specialization.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3311" skillLevel="4" />
              <row typeID="11082" skillLevel="4" />
              <row typeID="3304" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Motion Prediction" groupID="255" typeID="3312">
            <description>Improved ability at hitting moving targets. 5% bonus per skill level to weapon turret tracking speeds.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="trackingSpeedBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Rapid Firing" groupID="255" typeID="3310">
            <description>Skill at the rapid discharge of weapon turrets.  4% bonus per skill level to weapon turret rate of fire.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rofBonus" bonusValue="-4" />
            </rowset>
          </row>
          <row typeName="Sharpshooter" groupID="255" typeID="3311">
            <description>Skill at long-range weapon turret firing. 5% bonus to weapon turret optimal range per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rangeSkillBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Small Artillery Specialization" groupID="255" typeID="12201">
            <description>Specialist training in the operation of advanced Small Artillery.  2% bonus per skill level to the damage of small turrets requiring Small Artillery Specialization.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3311" skillLevel="3" />
              <row typeID="3302" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Small Autocannon Specialization" groupID="255" typeID="11084">
            <description>Specialist training in the operation of advanced small Autocannons. 2% bonus per skill level to the damage of small turrets requiring Small Autocannon Specialization.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3312" skillLevel="3" />
              <row typeID="3302" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Small Beam Laser Specialization" groupID="255" typeID="11083">
            <description>Specialist training in the operation of small Beam Lasers. 2% bonus per skill level to the damage of small turrets requiring Small Beam Laser Specialization.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3311" skillLevel="3" />
              <row typeID="3303" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Small Blaster Specialization" groupID="255" typeID="12210">
            <description>Specialist training in the operation of advanced small blasters. 2% bonus per skill level to the damage of small turrets requiring Small Blaster Specialization.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3312" skillLevel="3" />
              <row typeID="3301" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Small Energy Turret" groupID="255" typeID="3303">
            <description>Operation of small energy turrets. 5% Bonus to small energy turret damage per level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Small Hybrid Turret" groupID="255" typeID="3301">
            <description>Operation of small hybrid turrets. 5% Bonus to small hybrid turret damage per level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Small Projectile Turret" groupID="255" typeID="3302">
            <description>Operation of small projectile turrets. 5% Bonus to small projectile turret damage per level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Small Pulse Laser Specialization" groupID="255" typeID="12213">
            <description>Specialist training in the operation of small pulse lasers. 2% bonus per skill level to the damage of small turrets requiring Small Pulse Laser Specialization.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3312" skillLevel="3" />
              <row typeID="3303" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Small Railgun Specialization" groupID="255" typeID="11082">
            <description>Specialist training in the operation of advanced small railguns. 2% bonus per skill level to the damage of small turrets requiring Small Railgun Specialization.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3311" skillLevel="3" />
              <row typeID="3301" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Surgical Strike" groupID="255" typeID="3315">
            <description>Knowledge of spaceships' structural weaknesses.  3% bonus per skill level to the damage of all weapon turrets.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="3" />
            </rowset>
          </row>
          <row typeName="Tactical Weapon Reconfiguration" groupID="255" typeID="22043">
            <description>Skill at the operation of siege modules.  50-unit reduction in strontium clathrate consumption amount for module activation per skill level.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="11207" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="consumptionQuantityBonus" bonusValue="50" />
            </rowset>
          </row>
          <row typeName="Trajectory Analysis" groupID="255" typeID="3317">
            <description>Advanced understanding of zero-G physics. 5% bonus per skill level to weapon turret accuracy falloff.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="falloffBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Weapon Upgrades" groupID="255" typeID="3318">
            <description>Knowledge of gunnery computer systems, including the use of weapon upgrade modules. 5% reduction per skill level in the CPU needs of weapon turrets, launchers and smartbombs.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3300" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="cpuNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
        </rowset>
      </row>
      <row groupName="Industry" groupID="268">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Advanced Mass Production" groupID="268" typeID="24625">
            <description>Further training in the operation of multiple factories.  Ability to run 1 additional manufacturing job per skill level.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3387" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="manufacturingSlotBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Arkonor Processing" groupID="268" typeID="12180">
            <description>Specialization in Arkonor processing and refining. Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency. 5% reduction in Arkonor refining waste per skill level.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3389" skillLevel="5" />
              <row typeID="3409" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Bistot Processing" groupID="268" typeID="12181">
            <description>Specialization in Bistot processing and refining. Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency. 5% reduction in Bistot refining waste per skill level.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3389" skillLevel="5" />
              <row typeID="3409" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Crokite Processing" groupID="268" typeID="12182">
            <description>Specialization in Crokite processing and refining.  Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency. 5% reduction in Crokite refining waste per skill level.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3389" skillLevel="5" />
              <row typeID="3409" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Dark Ochre Processing" groupID="268" typeID="12183">
            <description>Specialization in Dark Ochre processing and refining.  Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency. 5% reduction in Dark Ochre refining waste per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3389" skillLevel="4" />
              <row typeID="3409" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Deep Core Mining" groupID="268" typeID="11395">
            <description>Skill at operating mining lasers requiring Deep Core Mining.  20% reduction per skill level in the chance of a damage cloud forming while mining Mercoxit.</description>
            <rank>6</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3386" skillLevel="5" />
              <row typeID="3410" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageCloudChanceReduction" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Drug Manufacturing" groupID="268" typeID="26224">
            <description>Needed to manufacture boosters. Can not be trained on Trial Accounts.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="durationSkillBonus" bonusValue="1" />
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Gas Cloud Harvesting" groupID="268" typeID="25544">
            <description>Skill at harvesting gas clouds.  Allows use of one gas cloud harvester per level. Can not be trained on Trial Accounts.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3386" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Gneiss Processing" groupID="268" typeID="12184">
            <description>Specialization in Gneiss processing and refining.  Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency. 5% reduction in Gneiss refining waste per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3389" skillLevel="4" />
              <row typeID="3409" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Hedbergite Processing" groupID="268" typeID="12185">
            <description>Specialization in Hedbergite processing and refining.  Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency.  5% reduction in Hedbergite refining waste per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3389" skillLevel="4" />
              <row typeID="3409" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Hemorphite Processing" groupID="268" typeID="12186">
            <description>Specialization in Hemorphite processing and refining. Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency.  5% reduction in Hemorphite refining waste per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3385" skillLevel="5" />
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Ice Harvesting" groupID="268" typeID="16281">
            <description>Skill at mining ice.  5% reduction per skill level to the cycle time of ice harvesters.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3386" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="iceHarvestCycleBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Ice Processing" groupID="268" typeID="18025">
            <description>Skill for Ice processing and refining. Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency. 5% reduction in Ice refining waste per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3389" skillLevel="5" />
              <row typeID="11443" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Industrial Reconfiguration" groupID="268" typeID="28585">
            <description>Skill at the operation of industrial core modules.  50-unit reduction in heavy water consumption amount for module activation per skill level.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="24625" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="consumptionQuantityBonus" bonusValue="50" />
            </rowset>
          </row>
          <row typeName="Industry" groupID="268" typeID="3380">
            <description>Allows basic operation of factories.  4% reduction in manufacturing time per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="durationSkillBonus" bonusValue="1" />
              <row bonusType="manufacturingTimeBonus" bonusValue="-4" />
            </rowset>
          </row>
          <row typeName="Jaspet Processing" groupID="268" typeID="12187">
            <description>Specialization in Jaspet processing and refining. Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency.  5% reduction in Jaspet refining waste per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3385" skillLevel="5" />
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Kernite Processing" groupID="268" typeID="12188">
            <description>Specialization in Kernite processing and refining. Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency.  5% reduction in Kernite refining waste per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3385" skillLevel="5" />
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Mass Production" groupID="268" typeID="3387">
            <description>Allows the operation of multiple factories. Ability to run 1 additional manufacturing job per level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3380" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="manufacturingSlotBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Mercoxit Processing" groupID="268" typeID="12189">
            <description>Specialization in Mercoxit processing and refining.  Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency.  5% reduction in Mercoxit refining waste per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3389" skillLevel="5" />
              <row typeID="3409" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Mining" groupID="268" typeID="3386">
            <description>Skill at using mining lasers. 5% bonus to mining turret yield per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="miningAmountBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Mining Upgrades" groupID="268" typeID="22578">
            <description>Skill at using mining upgrades. 5% reduction per skill level in CPU penalty of mining upgrade modules.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3386" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="miningUpgradeCPUReductionBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Omber Processing" groupID="268" typeID="12190">
            <description>Specialization in Omber processing and refining. Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency.  5% reduction in Omber refining waste per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3385" skillLevel="5" />
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Plagioclase Processing" groupID="268" typeID="12191">
            <description>Specialization in Plagioclase processing and refining. Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency. 5% reduction in Plagioclase refining waste per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3385" skillLevel="4" />
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Production Efficiency" groupID="268" typeID="3388">
            <description>Skill at efficiently using factories.  4% reduction per skill level to the material requirements needed for production.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3380" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="manufactureCostBonus" bonusValue="-4" />
            </rowset>
          </row>
          <row typeName="Pyroxeres Processing" groupID="268" typeID="12192">
            <description>Specialization in Pyroxeres processing and refining. Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency. 5% reduction in Pyroxeres refining waste per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3385" skillLevel="4" />
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Refinery Efficiency" groupID="268" typeID="3389">
            <description>Advanced skill at using refineries. 4% reduction in refinery waste per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3385" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="refiningYieldMutator" bonusValue="4" />
            </rowset>
          </row>
          <row typeName="Refining" groupID="268" typeID="3385">
            <description>Skill at using refineries.  2% reduction in refinery waste per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3380" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="refiningYieldMutator" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Scordite Processing" groupID="268" typeID="12193">
            <description>Specialization in Scordite processing and refining. Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency.  5% reduction in Scordite refining waste per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3385" skillLevel="4" />
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Scrapmetal Processing" groupID="268" typeID="12196">
            <description>Specialization in Scrapmetal processing and refining. Increases reprocessing returns for modules, ships and other reprocessable equipment. 5% reduction in ship and module refining waste per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3389" skillLevel="5" />
              <row typeID="3409" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Spodumain Processing" groupID="268" typeID="12194">
            <description>Specialization in Spodumain processing and refining. Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency.  5% reduction in Spodumain refining waste per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3389" skillLevel="4" />
              <row typeID="3409" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Supply Chain Management" groupID="268" typeID="24268">
            <description>Proficiency at starting manufacturing jobs remotely. Each level increases the distance at which jobs can be created. Level 1 allows for range within the same solar system, Level 2 extends that range to systems within 5 jumps, and each subsequent level then doubles it. Level 5 allows for full regional range.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3387" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Veldspar Processing" groupID="268" typeID="12195">
            <description>Specialization in Veldspar processing and refining. Allows a skilled refiner to utilize substandard refining facilities at considerably greater efficiency.  5% reduction in Veldspar refining waste per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3385" skillLevel="4" />
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="minmatarTechMutator" bonusValue="-5" />
            </rowset>
          </row>
        </rowset>
      </row>
      <row groupName="Leadership" groupID="258">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Armored Warfare" groupID="258" typeID="20494">
            <description>Basic proficiency at coordinating armored warfare.  Grants a 2% bonus to gang members' armor hit points per skill level. Note: The Gang bonus only works if you are the assigned gang booster and the gang is in fleet mode.

Note: Gang bonuses only affect gang members in space within the same solar system</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3348" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="armorHpBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Armored Warfare Specialist" groupID="258" typeID="11569">
            <description>Advanced proficiency at armored warfare.  Multiplies the effectiveness of armored warfare link modules by 100% per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3348" skillLevel="1" />
              <row typeID="20494" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Fleet Command" groupID="258" typeID="24764">
            <description>Allows command of a Fleet. Grants the Fleet Commander the ability to command a new Wing per skill level, up to a maximum of 5 Wings.</description>
            <rank>12</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="11574" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Information Warfare" groupID="258" typeID="20495">
            <description>Basic proficiency at coordinating information warfare.  Grants a 2% bonus to gang members' targeting range per skill level.  Note: The Gang bonus only works if you are the assigned gang booster and the gang is in fleet mode.

Note: Gang bonuses only affect gang members in space within the same solar system</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3348" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="maxTargetRangeBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Information Warfare Specialist" groupID="258" typeID="3352">
            <description>Advanced proficiency at information warfare.  Multiplies the effectiveness of information warfare link modules by 100% per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3348" skillLevel="1" />
              <row typeID="20495" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Leadership" groupID="258" typeID="3348">
            <description>Allows command of a squadron. Increases maximum squadron size by 2 members per skill level, up to a maximum of 10 members.

Grants a 2% bonus to gang members' targeting speed per skill level. Only the bonus of the gang member with the highest level in this skill is used.

Note: Gang bonuses only affect gang members in space within the same solar system</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="scanResolutionBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Mining Director" groupID="258" typeID="22552">
            <description>Advanced proficiency at group mining.  100% bonus to effectiveness of Mining Foreman link modules per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3348" skillLevel="1" />
              <row typeID="22536" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Mining Foreman" groupID="258" typeID="22536">
            <description>Basic proficiency at coordinating mining operations.  Grants a 2% bonus to gang members' mining yield per level.  Note: The Gang bonus only works if you are the assigned gang booster and the gang is in fleet mode.
</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3348" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="miningAmountBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Siege Warfare" groupID="258" typeID="3350">
            <description>Basic proficiency at coordinating a gang's defenses.  Grants a 2% bonus to gang members' shield capacity per skill level.  Note: The Gang bonus only works if you are the assigned gang booster and the gang is in fleet mode.

Note: Gang bonuses only affect gang members in space within the same solar system</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3348" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="shieldCapacityBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Siege Warfare Specialist" groupID="258" typeID="3351">
            <description>Advanced proficiency at siege warfare.  Multiplies the effectiveness of siege warfare link modules by 100% per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3348" skillLevel="1" />
              <row typeID="3350" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Skirmish Warfare" groupID="258" typeID="3349">
            <description>Basic proficiency at coordinating hit-and-run warfare.  Grants a 2% bonus to gang members' maximum velocity per skill level.  Note: The Gang bonus only works if you are the assigned gang booster and the gang is in fleet mode.

Note: Gang bonuses only affect gang members in space within the same solar system</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3348" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="velocityBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Skirmish Warfare Specialist" groupID="258" typeID="11572">
            <description>Advanced proficiency at skirmish warfare.  Multiplies the effectiveness of skirmish warfare link modules by 100% per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3348" skillLevel="1" />
              <row typeID="3349" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Warfare Link Specialist" groupID="258" typeID="3354">
            <description>Improved gang leadership.  Boosts effectiveness of all warfare link modules by 10% per level.</description>
            <rank>6</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3348" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="squadronCommandBonus" bonusValue="10" />
            </rowset>
          </row>
          <row typeName="Wing Command" groupID="258" typeID="11574">
            <description>Allows command of a Wing. Grants the Wing Commander the ability to operate a new Squadron per skill level, up to a maximum of 5 Squadrons.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3348" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
        </rowset>
      </row>
      <row groupName="Learning" groupID="267">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Analytical Mind" groupID="267" typeID="3377">
            <description>1 point bonus to your Intelligence attribute per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="intelligenceBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Clarity" groupID="267" typeID="12387">
            <description>SOCT Advanced awareness training. While this training obviously is of great value to anyone, the most impressive results are achieved by students with great latent potential. These students develop almost superhuman sensory abilities and can react to stimuli so fast that, to the untrained eye, it almost seems as if they can predict the future. 

Adds 1 additional point to your Perception attribute per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3379" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="perceptionBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Eidetic Memory" groupID="267" typeID="12385">
            <description>SOCT Advanced mnemonic training. While this training obviously is of great value to anyone, the most impressive results are achieved by students with great latent potential, allowing them to recall nearly anything they have ever experienced with total lucidity.

Adds 1 additional point to your Memory attribute per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3378" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="memoryBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Empathy" groupID="267" typeID="3376">
            <description>1 point bonus to your Charisma attribute per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="charismaBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Focus" groupID="267" typeID="12386">
            <description>SOCT Advanced self-discipline training. While this training obviously is of great value to anyone, the most impressive results are achieved by students with great latent potential. These students are able to remain focused and alert under extreme pressure, and can ignore pain and fatigue for extended periods of time. 

Adds 1 additional point to your Willpower attribute per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3375" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="willpowerBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Instant Recall" groupID="267" typeID="3378">
            <description>1 point bonus to your Memory attribute per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="memoryBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Iron Will" groupID="267" typeID="3375">
            <description>1 point bonus to your Willpower attribute per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="willpowerBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Learning" groupID="267" typeID="3374">
            <description>2% bonus per level to all attributes resulting in a overall faster skill training time.

 


</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="learningBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Logic" groupID="267" typeID="12376">
            <description>SOCT Advanced intelligence training. While this training obviously is of great value to anyone, the most impressive results are achieved by students with great latent potential. These students develop an intuitive understanding of complex patterns and are able to grasp esoteric concepts with incredible ease.  

Adds 1 additional point to your Intelligence attribute per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3377" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="intelligenceBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Presence" groupID="267" typeID="12383">
            <description>SOCT Advanced social consciousness training. While this training obviously is of great value to anyone, the most impressive results are achieved by students with great latent potential.  Training in this skill allows a student to develop heightened mental sensitivity, to the point of being able to sense the surface mood and emotions of a person.

Adds 1 additional point to your Charisma attribute per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3376" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="charismaBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Spatial Awareness" groupID="267" typeID="3379">
            <description>1 point bonus to your Perception attribute per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="perceptionBonus" bonusValue="1" />
            </rowset>
          </row>
        </rowset>
      </row>
      <row groupName="Mechanic" groupID="269">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Armor Rigging" groupID="269" typeID="26253">
            <description>Advanced understanding of armor subsystems. Allows makeshift modifications to armor subsystems through the use of rigs. 

10% reduction in Armor Rig drawbacks per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="26252" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rigDrawbackBonus" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Astronautics Rigging" groupID="269" typeID="26254">
            <description>Advanced understanding of a ships navigational subsystems. Allows makeshift modifications to warp drive, sub warp drive and other navigational subsystems through the use of rigs. 

10% reduction in Astronautics Rig drawbacks per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="26252" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rigDrawbackBonus" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Battleship Construction" groupID="269" typeID="3398">
            <description>Skill at the construction of advanced battleships. Required for advanced battleship BP manufacturing</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3397" skillLevel="4" />
              <row typeID="3395" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Capital Remote Armor Repair Systems" groupID="269" typeID="24568">
            <description>Operation of capital sized remote armor repair systems. 5% reduced capacitor need for capital remote armor repair system modules per skill level.</description>
            <rank>10</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="16069" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Capital Remote Hull Repair Systems" groupID="269" typeID="27936">
            <description>Operation of remote capital class remote hull repair systems. 5% reduced capacitor need for capital class remote hull repair system modules per skill level.</description>
            <rank>10</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="27902" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Capital Repair Systems" groupID="269" typeID="21803">
            <description>Operation of capital armor/hull repair modules. 5% reduction in capital repair systems duration per skill level.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="5" />
              <row typeID="3394" skillLevel="5" />
              <row typeID="3393" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="durationSkillBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Capital Ship Construction" groupID="269" typeID="22242">
            <description>Skill at the construction of capital ships.</description>
            <rank>14</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="5" />
              <row typeID="3380" skillLevel="5" />
              <row typeID="3388" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Cruiser Construction" groupID="269" typeID="3397">
            <description>Skill at the construction of advanced cruisers. Required for advanced cruiser BP manufacturing  </description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="3" />
              <row typeID="3395" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Drones Rigging" groupID="269" typeID="26255">
            <description>Advanced understanding of a ships drone control subsystems. Allows makeshift modifications to drone subsystems through the use of rigs. 

10% reduction in Drone Rig drawbacks per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="26252" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rigDrawbackBonus" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Electronic Superiority Rigging" groupID="269" typeID="26256">
            <description>Advanced understanding of electronics subsystems. Allows makeshift modifications to targeting, scanning and ECM systems through the use of rigs. 

10% reduction in Electronic Superiority Rig drawbacks per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="26252" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rigDrawbackBonus" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="EM Armor Compensation" groupID="269" typeID="22806">
            <description>To active armor hardeners: 3% bonus per skill level to Armor EM resistance when the modules are not active
To passive armor hardeners: 5% bonus per skill level to Armor EM resistance</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3394" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="hardeningBonus" bonusValue="5" />
              <row bonusType="hardeningbonus2" bonusValue="3" />
            </rowset>
          </row>
          <row typeName="Energy Weapon Rigging" groupID="269" typeID="26258">
            <description>Advanced understanding of the interface between energy weapons and the numerous ship systems. Allows makeshift modifications to ship system architecture through the use of rigs. 

10% reduction in Energy Weapon Rig drawbacks per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="26252" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rigDrawbackBonus" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Explosive Armor Compensation" groupID="269" typeID="22807">
            <description>To active armor hardeners: 3% bonus per skill level to Armor Explosive resistance when the modules are not active
To passive armor hardeners: 5% bonus per skill level to Armor Explosive resistance</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3394" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="hardeningBonus" bonusValue="5" />
              <row bonusType="hardeningbonus2" bonusValue="3" />
            </rowset>
          </row>
          <row typeName="Frigate Construction" groupID="269" typeID="3395">
            <description>Skill at the construction of advanced frigates. Required for advanced frigate BP manufacturing </description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="1" />
              <row typeID="3380" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Hull Upgrades" groupID="269" typeID="3394">
            <description>Skill at maintaining your ship's armour and installing hull upgrades like expanded cargoholds and inertial stabilizers.  Grants a 5% bonus to armor hit points per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="armorHpBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Hybrid Weapon Rigging" groupID="269" typeID="26259">
            <description>Advanced understanding of the interface between hybrid weapons and the numerous ship systems. Allows makeshift modifications to ship system architecture through the use of rigs. 

10% reduction in Hybrid Weapon Rig drawbacks per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="26252" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rigDrawbackBonus" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Industrial Construction" groupID="269" typeID="3396">
            <description>Skill at the construction of advanced industrials.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="2" />
              <row typeID="3380" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Jury Rigging" groupID="269" typeID="26252">
            <description>General understanding of the inner workings of starship components. Allows makeshift modifications to ship subsystems through the use of rigs. Required learning for further study in the field of rigging. </description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Kinetic Armor Compensation" groupID="269" typeID="22808">
            <description>To active armor hardeners: 3% bonus per skill level to Armor Kinetic resistance when the modules are not active
To passive armor hardeners: 5% bonus per skill level to Armor Kinetic resistance</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3394" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="hardeningBonus" bonusValue="5" />
              <row bonusType="hardeningbonus2" bonusValue="3" />
            </rowset>
          </row>
          <row typeName="Launcher Rigging" groupID="269" typeID="26260">
            <description>Advanced understanding of the interface between Missile Launchers and the numerous ship systems. Allows makeshift modifications to ship system architecture through the use of rigs. 

10% reduction in Launcher Rig drawbacks per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="26252" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rigDrawbackBonus" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Mechanic" groupID="269" typeID="3392">
            <description>Skill at maintaining the mechanical components and structural integrity of a spaceship.  5% bonus to structure hit points per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="hullHpBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Nanite Interfacing" groupID="269" typeID="28880">
            <description>Improved control of nanites.  20% increased repair amount per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="5" />
              <row typeID="28879" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="moduleRepairRateBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Nanite Operation" groupID="269" typeID="28879">
            <description>Skill at operating nanites.  5% reduction in nanite consumption per level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="shipBrokenRepairCostMultiplierBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Outpost Construction" groupID="269" typeID="3400">
            <description>Skill at constructing outposts.</description>
            <rank>16</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="5" />
              <row typeID="3380" skillLevel="5" />
              <row typeID="11584" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Projectile Weapon Rigging" groupID="269" typeID="26257">
            <description>Advanced understanding of the interface between projectile weapons and the numerous ship systems. Allows makeshift modifications to ship system architecture through the use of rigs. 

10% reduction in Projectile Weapon Rig drawbacks per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="26252" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rigDrawbackBonus" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Remote Armor Repair Systems" groupID="269" typeID="16069">
            <description>Operation of remote armor repair systems. 5% reduced capacitor need for remote armor repair system modules per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="3" />
              <row typeID="3393" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Remote Hull Repair Systems" groupID="269" typeID="27902">
            <description>Operation of remote hull repair systems. 5% reduced capacitor need for remote hull repair system modules per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Repair Systems" groupID="269" typeID="3393">
            <description>Operation of armor/hull repair modules. 5% reduction in repair systems duration per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="durationSkillBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Salvaging" groupID="269" typeID="25863">
            <description>Proficiency at salvaging ship wrecks.  Required skill for the use of salvager modules.  5% increase in chance of salvage retrieval per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3392" skillLevel="3" />
              <row typeID="3551" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="accessDifficultyBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Shield Rigging" groupID="269" typeID="26261">
            <description>Advanced understanding of shield subsystems. Allows makeshift modifications to shield subsystems through the use of rigs. 

10% reduction in Shield Rig drawbacks per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="26252" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rigDrawbackBonus" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Tactical Logistics Reconfiguration" groupID="269" typeID="27906">
            <description>Skill at the operation of triage modules.  50-unit reduction in strontium clathrate consumption amount for module activation per skill level.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="12096" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="consumptionQuantityBonus" bonusValue="50" />
            </rowset>
          </row>
          <row typeName="Thermic Armor Compensation" groupID="269" typeID="22809">
            <description>To active armor hardeners: 3% bonus per skill level to Armor Thermal resistance when the modules are not active
To passive armor hardeners: 5% bonus per skill level to Armor Thermal resistance</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3394" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="hardeningBonus" bonusValue="5" />
              <row bonusType="hardeningbonus2" bonusValue="3" />
            </rowset>
          </row>
        </rowset>
      </row>
      <row groupName="Missile Launcher Operation" groupID="256">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Bomb Deployment" groupID="256" typeID="28073">
            <description>Basic operation of bomb delivery systems. 5% reduction of Bomb Launcher reactivation delay per skill level.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="12441" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rofBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Citadel Torpedoes" groupID="256" typeID="21668">
            <description>Skill at the handling and firing of citadel torpedoes.  5% bonus to citadel torpedo damage per skill level.</description>
            <rank>7</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="5" />
              <row typeID="3325" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Cruise Missile Specialization" groupID="256" typeID="20212">
            <description>Specialist training in the operation of advanced cruise missile launchers.  2% bonus per level to the rate of fire of modules requiring Cruise Missile Specialization.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="1" />
              <row typeID="3326" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rofBonus" bonusValue="-2" />
            </rowset>
          </row>
          <row typeName="Cruise Missiles" groupID="256" typeID="3326">
            <description>Skill at the handling and firing of very large guided missiles.  5% bonus to cruise missile damage per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="5" />
              <row typeID="3324" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Defender Missiles" groupID="256" typeID="3323">
            <description>Skill with anti-missile missiles.Special: 5% bonus to defender missile max velocity per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="missileVelocityBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="FoF Missiles" groupID="256" typeID="3322">
            <description>Skill with friend or foe missiles. Special: 5% bonus to F.O.F (light, heavy and cruise) damage per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Guided Missile Precision" groupID="256" typeID="20312">
            <description>Skill at precision missile homing.  Proficiency at this skill increases the accuracy of a fired missile's exact point of impact, resulting in greater damage to small targets.  5% decreased factor of signature radius for light, heavy and cruise missile explosions per level of skill.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="aoeCloudSizeBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Heavy Assault Missile Specialization" groupID="256" typeID="25718">
            <description>Specialist training in the operation of advanced heavy assault missile launchers.  2% bonus per level to the rate of fire of modules requiring Heavy Assault Missile Specialization.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="1" />
              <row typeID="25719" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rofBonus" bonusValue="-2" />
            </rowset>
          </row>
          <row typeName="Heavy Assault Missiles" groupID="256" typeID="25719">
            <description>Skill with assault missiles. Special: 5% bonus to assault missile damage per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="3" />
              <row typeID="3321" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Heavy Missile Specialization" groupID="256" typeID="20211">
            <description>Specialist training in the operation of advanced heavy missile launchers.  2% bonus per level to the rate of fire of modules requiring Heavy Missile Specialization.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="1" />
              <row typeID="3324" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rofBonus" bonusValue="-2" />
            </rowset>
          </row>
          <row typeName="Heavy Missiles" groupID="256" typeID="3324">
            <description>Skill with heavy missiles. Special: 5% bonus to heavy missile damage per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="3" />
              <row typeID="3321" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Missile Bombardment" groupID="256" typeID="12441">
            <description>Proficiency at long-range missile combat. 10% bonus to all missiles' maximum flight time per level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="maxFlightTimeBonus" bonusValue="10" />
            </rowset>
          </row>
          <row typeName="Missile Launcher Operation" groupID="256" typeID="3319">
            <description>Basic operation of missile launcher systems. 2% Bonus to missile launcher rate of fire per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rofBonus" bonusValue="-2" />
            </rowset>
          </row>
          <row typeName="Missile Projection" groupID="256" typeID="12442">
            <description>Skill at boosting missile bay propulsion systems and manipulating guided missiles' jet engines.  10% bonus to all missiles' maximum velocity per level.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="speedFactor" bonusValue="10" />
            </rowset>
          </row>
          <row typeName="Rapid Launch" groupID="256" typeID="21071">
            <description>Proficiency at rapid missile launcher firing.  3% bonus to missile launcher rate of fire per level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rofBonus" bonusValue="-3" />
            </rowset>
          </row>
          <row typeName="Rocket Specialization" groupID="256" typeID="20209">
            <description>Specialist training in the operation of advanced rocket launchers.  2% bonus per level to the rate of fire of modules requiring Rocket Specialization.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="1" />
              <row typeID="3320" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rofBonus" bonusValue="-2" />
            </rowset>
          </row>
          <row typeName="Rockets" groupID="256" typeID="3320">
            <description>Skill with small short range missiles.Special: 5% bonus to rocket damage per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Standard Missile Specialization" groupID="256" typeID="20210">
            <description>Specialist training in the operation of advanced standard missile launchers and assault launchers.  2% bonus per level to the rate of fire of modules requiring Standard Missile Specialization.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="1" />
              <row typeID="3321" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rofBonus" bonusValue="-2" />
            </rowset>
          </row>
          <row typeName="Standard Missiles" groupID="256" typeID="3321">
            <description>Skill with manually targeted missiles.Special: 5% Bonus to light missile damage per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Target Navigation Prediction" groupID="256" typeID="20314">
            <description>Proficiency at optimizing a missile's flight path to negate the effects of a target's speed upon the explosion's impact.  10% decrease per level in factor of target's velocity for all missiles.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="aoeVelocityBonus" bonusValue="10" />
            </rowset>
          </row>
          <row typeName="Torpedo Specialization" groupID="256" typeID="20213">
            <description>Specialist training in the operation of advanced siege launchers.  2% bonus per level to the rate of fire of modules requiring Torpedo Specialization.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="1" />
              <row typeID="3325" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="rofBonus" bonusValue="-2" />
            </rowset>
          </row>
          <row typeName="Torpedoes" groupID="256" typeID="3325">
            <description>Skill at the handling and firing of torpedoes.  5% bonus to torpedo damage per skill level.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="4" />
              <row typeID="3324" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Warhead Upgrades" groupID="256" typeID="20315">
            <description>Proficiency at upgrading missile warheads with deadlier payloads.  2% bonus to all missile damage per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3319" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="2" />
            </rowset>
          </row>
        </rowset>
      </row>
      <row groupName="Navigation" groupID="275">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Acceleration Control" groupID="275" typeID="3452">
            <description>Skill at efficiently using Afterburners and MicroWarpdrives. 5% Bonus to Afterburner and MicroWarpdrive speed boost per skill level.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3449" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="speedFBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Afterburner" groupID="275" typeID="3450">
            <description>Skill at using afterburners. 10% bonus to Afterburner duration per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3449" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="durationBonus" bonusValue="10" />
            </rowset>
          </row>
          <row typeName="Evasive Maneuvering" groupID="275" typeID="3453">
            <description>Improved skill at efficiently turning and accelerating a spaceship.  5% improved ship agility for all ships per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3449" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="agilityBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Fuel Conservation" groupID="275" typeID="3451">
            <description>Improved control over afterburner energy consumption. 10% reduction in afterburner capacitor needs per skill level.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3449" skillLevel="2" />
              <row typeID="3450" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capNeedBonus" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="High Speed Maneuvering" groupID="275" typeID="3454">
            <description>Skill at using MicroWarpdrives. 5% reduction in MicroWarpdrive capacitor usage per skill level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3449" skillLevel="4" />
              <row typeID="3450" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="capacitorNeedMultiplier" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Jump Drive Calibration" groupID="275" typeID="21611">
            <description>Advanced skill at using Jump Drives.  Each skill level grants a 25% increase in maximum jump range.</description>
            <rank>9</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3456" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="jumpDriveRangeBonus" bonusValue="25" />
            </rowset>
          </row>
          <row typeName="Jump Drive Operation" groupID="275" typeID="3456">
            <description>Skill at using Jump Drives.  Each skill level reduces the capacitor need of initiating a jump by 5%.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3449" skillLevel="5" />
              <row typeID="3455" skillLevel="5" />
              <row typeID="3402" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="jumpDriveCapacitorNeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Jump Fuel Conservation" groupID="275" typeID="21610">
            <description>Proficiency at regulating energy flow to the jump drive. 10% reduction in ice consumption amount for jump drive operation per light year per skill level.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3456" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="consumptionQuantityBonusPercentage" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Navigation" groupID="275" typeID="3449">
            <description>Skill at regulating the power output of ship thrusters. 5% bonus to sub-warp ship velocity per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="velocityBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Warp Drive Operation" groupID="275" typeID="3455">
            <description>Skill at managing warp drive efficiency.  Each skill level reduces the capacitor need of initiating warp by 10%.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3449" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="warpCapacitorNeedBonus" bonusValue="-10" />
            </rowset>
          </row>
        </rowset>
      </row>
      <row groupName="Science" groupID="270">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Advanced Laboratory Operation" groupID="270" typeID="24624">
            <description>Further training in the operation of multiple laboratories.  Ability to run 1 additional research job per skill level.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3406" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="laboratorySlotsBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Amarr Encryption Methods" groupID="270" typeID="23087">
            <description>Understanding of the data encryption methods used by the Amarr Empire and its allies.



</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="21718" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Amarrian Starship Engineering" groupID="270" typeID="11444">
            <description>Skill and knowledge of Amarrian Starship Engineering. 

Used Exclusively in the research of Amarrian Ships of all Sizes.

Allows Amarrian Starship Engineering research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints

Can not be trained on Trial Accounts</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3392" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Archaeology" groupID="270" typeID="13278">
            <description>Proficiency at identifying and analyzing ancient artifacts.  Required skill for the use of Analyzer modules.  5% increase in chance of archaeological find per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3551" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Astrogeology" groupID="270" typeID="3410">
            <description>Skill at analyzing the content of celestial objects with the intent of mining them. 5% bonus to mining turret yield per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="4" />
              <row typeID="3386" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="miningAmountBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Astrometric Pinpointing" groupID="270" typeID="25810">
            <description>Greater accuracy in hunting down targets found through scanning. Reduces maximum scan deviation by 10% per level.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3412" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="maxScanDeviationModifier" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Astrometric Triangulation" groupID="270" typeID="25811">
            <description>Skill at the advanced operation of long range scanners. 5% scan strength bonus per level of skill.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3412" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="scanStrengthBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Astrometrics" groupID="270" typeID="3412">
            <description>Skill at operating long range scanners. Adds one scan group per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Astronautic Engineering" groupID="270" typeID="11487">
            <description>Skill and knowledge of Astronautics and its use in the development of advanced technology.  Allows Astronautic Engineering research to be performed with the help of a research agent. It is also needed for all research and manufacturing operations on related blueprints. Can not be trained on Trial Accounts.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3392" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Biology" groupID="270" typeID="3405">
            <description>The science of life and of living organisms, and how chemicals affect them. 20% Bonus to attribute booster duration per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="durationBonus" bonusValue="20" />
            </rowset>
          </row>
          <row typeName="Caldari Encryption Methods" groupID="270" typeID="21790">
            <description>Understanding of the data encryption methods used by the Caldari State and its allies.
</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="21718" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Caldari Starship Engineering" groupID="270" typeID="11454">
            <description>Skill and knowledge of Caldari Starship Engineering and its use in the development of advanced technology. 

Uses in the research of Caldari Ships of all Sizes.

Allows Caldari Starship Engineering research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints

Can not be trained on Trial Accounts</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3392" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Cloning Facility Operation" groupID="270" typeID="24606">
            <description>Needed for use of the Clone Vat Bay module. 

Special: Increases a Clone Vat Bay's maximum clone capacity by 15% per skill level.</description>
            <rank>10</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="20533" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="maxJumpClonesBonus" bonusValue="15" />
            </rowset>
          </row>
          <row typeName="Cybernetics" groupID="270" typeID="3411">
            <description>The science of interfacing biological and machine components. Allows the use of cybernetic implants.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Doomsday Operation" groupID="270" typeID="24563">
            <description>Skill at operating titan doomsday weapons. 10% increased damage per level.</description>
            <rank>14</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3421" skillLevel="5" />
              <row typeID="11207" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="damageMultiplierBonus" bonusValue="10" />
            </rowset>
          </row>
          <row typeName="Electromagnetic Physics" groupID="270" typeID="11448">
            <description>Skill and knowledge of Electromagnetic Physics and its use in the development of advanced technology. 

Uses primarily in the research of Railgun weaponry and various electronic systems.  

Allows Electromagnetic Physics research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints.

Can not be trained on Trial Accounts.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3426" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Electronic Engineering" groupID="270" typeID="11453">
            <description>Skill and knowledge of Electronic Engineering and its use in the development of advanced technology. 

Used in all Electronics and Drone research.  

Allows Electronic Engineering research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints

Can not be trained on Trial Accounts</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3426" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Gallente Encryption Methods" groupID="270" typeID="23121">
            <description>Understanding of the data encryption methods used by the Gallente Federation and its allies.



</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="21718" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Gallentean Starship Engineering" groupID="270" typeID="11450">
            <description>Skill and knowledge of Gallente Starship Engineering and its use in the development of advanced technology. 

Uses in the research of Gallente Ships of all Sizes.

Allows Gallente Starship Engineering research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints

Can not be trained on Trial Accounts</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3392" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Genetic Engineering" groupID="270" typeID="3404">
            <description>The science of interfacing biological and machine components. Allows the use of DNA mutators.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Graviton Physics" groupID="270" typeID="11446">
            <description>Skill and knowledge of Graviton physics and its use in the development of advanced technology. 

Uses primarily in the research of Cloaking and other spatial distortion devices as well as Graviton based missiles and smartbombs. 

Allows Graviton Physics research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints.

Can not be trained on Trial Accounts.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3413" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Gunnery Interfaces" groupID="270" typeID="13280">
            <description>The skill interfacing with a ships turrets. Allows the use of advanced gunnery implants. </description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3411" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Hacking" groupID="270" typeID="21718">
            <description>Proficiency at breaking into guarded computer systems.  Required skill for the use of codebreaker modules.  5% increase in chance of data retrieval per level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3432" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="High Energy Physics" groupID="270" typeID="11433">
            <description>Skill and knowledge of High Energy Physics and its use in the development of advanced technology. 

Uses primarily in the research of various energy system modules as well as smartbombs and laser based weaponry. 

Allows High Energy Physics research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints

Can not be trained on Trial Accounts</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3413" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Hydromagnetic Physics" groupID="270" typeID="11443">
            <description>Skill and knowledge of Hydromagnetic Physics and its use in the development of advanced technology . 

Uses primarily in the research of shield system.

Allows Hydromagnetic Physics research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints.

Can not be trained on Trial Accounts.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3413" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Infomorph Psychology" groupID="270" typeID="24242">
            <description>Psychological training that strengthens the pilot's mental tenacity. The reality of having one's consciousness detached from one's physical form, scattered across the galaxy and then placed in a vat-grown clone can be very unsettling to the untrained mind.

Allows 1 jump clone per level.

Note: Clones can only be installed in stations with medical facilities or in ships with clone vat bays. Installed clones are listed in the character sheet.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="maxJumpClones" bonusValue="0" />
            </rowset>
          </row>
          <row typeName="Jump Portal Generation" groupID="270" typeID="24562">
            <description>Skill for the generation of jump portals to distant solar systems. 10% reduced material cost for jump portal activation per level.</description>
            <rank>14</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3412" skillLevel="5" />
              <row typeID="3456" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="consumptionQuantityBonus" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Laboratory Operation" groupID="270" typeID="3406">
            <description>Allows basic operation of research facilities.  Ability to run 1 additional research job per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="laboratorySlotsBonus" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Laser Physics" groupID="270" typeID="11447">
            <description>Skill and knowledge of Laser Physics and its use in the development of advanced Technology. 

Used primarily in the research of Laser weaponry as well as EM based missiles and smartbombs.

Allows Laser Physics research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints.

Can not be trained on Trial Accounts.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3413" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Mechanical Engineering" groupID="270" typeID="11452">
            <description>Skill and knowledge of Mechanical Engineering and its use in the development of advanced technology. 

Used in all Starship research as well as hull and armor repair systems.  

Allows Mechanical Engineering research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints

Can not be trained on Trial Accounts</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3392" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Metallurgy" groupID="270" typeID="3409">
            <description>Advanced knowledge of mineral composition. 5% Bonus to material efficiency research speed per skill level.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="mineralNeedResearchBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Minmatar Encryption Methods" groupID="270" typeID="21791">
            <description>Understanding of the data encryption methods used by the Minmatar Republic and its allies.



</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="21718" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Minmatar Starship Engineering" groupID="270" typeID="11445">
            <description>Skill and knowledge of Minmatar Starship Engineering and its use in the development of advanced technology. 

Used in the research of Minmatar Ships of all Sizes.

Allows Minmatar Starship Engineering research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints

Can not be trained on Trial Accounts</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3392" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Molecular Engineering" groupID="270" typeID="11529">
            <description>Skill and knowledge of Molecular Physics and its use in the development of advanced technology. 

Uses primarily in the research of various hull and propulsion
systems.  

Allows Molecular Engineering research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints.

Can not be trained on Trial Accounts.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3392" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Nanite Control" groupID="270" typeID="25538">
            <description>Proficiency at reducing the severity of the side effects experienced upon injection of combat boosters.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="boosterAttributeModifier" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Nanite Engineering" groupID="270" typeID="11442">
            <description>Skill and knowledge of Nanorobotics and its use in the development of advanced technology . 

Uses primarily in the research of various armor and hull systems. 

Allows Nanite Engineering research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints

Can not be trained on Trial Accounts</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3426" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Neurotoxin Recovery" groupID="270" typeID="25530">
            <description>Proficiency at biofeedback techniques intended to negate the side effects typically experienced upon injection of combat boosters.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="25538" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="boosterChanceBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Nuclear Physics" groupID="270" typeID="11451">
            <description>Skill and knowledge of Nuclear physics and its use in the development of advanced technology.  

Uses primarily in the research of Projectile weaponry as well as Nuclear missiles and smartbombs. 

Allows Nuclear Physics research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints.

Can not be trained on Trial Accounts.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3413" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Plasma Physics" groupID="270" typeID="11441">
            <description>Skill and knowledge of Plasma physics and its use in the development of advanced technology. 

Uses primarily in the research of particle blaster weaponry as well as plasma based missiles and smartbombs. 

Allows Plasma Physics research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints

Can not be trained on Trial Accounts</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3413" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Quantum Physics" groupID="270" typeID="11455">
            <description>Skill and knowledge of Quantum Physics and its use in the development of advanced Technology. 

Uses primarily in the research of shield systems and Particle Blasters.  

Allows Quantum Physics research to be performed through a research agent. 

Needed for all research and manufacturing operations on related blueprints.

Can not be trained on Trial Accounts.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3413" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Research" groupID="270" typeID="3403">
            <description>Skill at researching more efficient production methods. 5% bonus to blueprint manufacturing time research per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="blueprintmanufactureTimeBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Research Project Management" groupID="270" typeID="12179">
            <description>Skill at overseeing agent research and development projects.  Allows the simultaneous use of 1 additional Research and Development agent per skill level.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3406" skillLevel="5" />
              <row typeID="3403" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>memory</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="maxAttackTargets" bonusValue="1" />
              <row bonusType="researchGangSizeBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Rocket Science" groupID="270" typeID="11449">
            <description>Skill and knowledge of Rocket Science and its use in the development of advanced technology. 

Uses primarily in the research of missiles and propulsion systems.  

Allows Rocket Science research to be performed with the help of a research agent. 

Needed for all research and manufacturing operations on related blueprints

Can not be trained on Trial Accounts</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="5" />
              <row typeID="3392" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Science" groupID="270" typeID="3402">
            <description>Basic understanding of scientific principles. 5% Bonus to blueprint copying speed per level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="copySpeedBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Scientific Networking" groupID="270" typeID="24270">
            <description>Skill at running research operations remotely. Each level increases the distance at which research projects can be started. Level 1 allows for range within the same solar system, Level 2 extends that range to systems within 5 jumps, and each subsequent level then doubles it. Level 5 allows for full regional range.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3406" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Signal Acquisition" groupID="270" typeID="25739">
            <description>Skill for the advanced operation of long range scanners. 10% faster scanning with scan probes per level.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="durationBonus" bonusValue="-10" />
            </rowset>
          </row>
          <row typeName="Sleeper Technology" groupID="270" typeID="21789">
            <description>Basic understanding of interfacing with Sleeper technology.

The Sleepers were masters of virtual reality, neural interfacing and cryotechnology.

Allows the rudimentary use of Sleeper components in the creation of advanced technology, even though the scientific theories behind them remain a mystery.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="13278" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Takmahl Technology" groupID="270" typeID="23123">
            <description>Basic understanding of interfacing with Takmahl technology.

The Takmahl nation excelled in cybernetics and bio-engineering.

Allows the rudimentary use of Takmahl components in the creation of advanced technology, even though the scientific theories behind them remain a mystery.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="13278" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Talocan Technology" groupID="270" typeID="20433">
            <description>Basic understanding of interfacing with Talocan technology.

The Talocan were masters of Spatial manipulation and Hypereuclidean Mathematics.

Allows the rudimentary use of Talocan components in the creation of advanced technology, even though the scientific theories behind them remain a mystery.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="13278" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Thermodynamics" groupID="270" typeID="28164">
            <description>Advanced understanding of the laws of thermodynamics. Allows you to deliberately overheat a ship's modules in order to push them beyond their intended limit. Also gives you the ability to frown in annoyance whenever you hear someone mention a perpetual motion unit.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3413" skillLevel="5" />
              <row typeID="3418" skillLevel="5" />
              <row typeID="3402" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="thermodynamicsHeatDamage" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Yan Jung Technology" groupID="270" typeID="23124">
            <description>Basic understanding of interfacing with Yan Jung technology.

The Yan Jung nation possessed advanced gravitronic technology and force field theories.

Allows the rudimentary use of Yan Jung components in the creation of advanced technology, even though the scientific theories behind them remain a mystery.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="13278" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>intelligence</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
        </rowset>
      </row>
      <row groupName="Social" groupID="278">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Bureaucratic Connections" groupID="278" typeID="16546">
            <description>Understanding of corporate bureaucracies.

Improves loyalty point gain by 5% per level when working for agents in the following corporation divisions:

Administration	
Internal Security
Personnel
Storage
Archives	
Financial
</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3363" skillLevel="3" />
              <row typeID="3355" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Connections" groupID="278" typeID="3359">
            <description>Skill at interacting with friendly NPCs. 4% Bonus to effective standing towards friendly NPC Corporations.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3355" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="connectionBonusMutator" bonusValue="0.4" />
            </rowset>
          </row>
          <row typeName="Criminal Connections" groupID="278" typeID="3361">
            <description>Skill at interacting with criminal NPCs. 0.4 bonus to effective standing towards NPCs with low Concord standing.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3355" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="criminalConnectionsMutator" bonusValue="0.4" />
            </rowset>
          </row>
          <row typeName="DED Connections" groupID="278" typeID="3362">
            <description>Skill at dealing with Concord Department and negotiating bounties 

Bonus fee of 1.500 isk per pirate head per level of the skill</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3355" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="bountySkillBonus" bonusValue="1500" />
            </rowset>
          </row>
          <row typeName="Diplomacy" groupID="278" typeID="3357">
            <description>Skill at interacting with hostile Agents. 0.4 Bonus per level to effective standing towards hostile Agents.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3355" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="diplomacyMutator" bonusValue="0.4" />
            </rowset>
          </row>
          <row typeName="Fast talk" groupID="278" typeID="3358">
            <description>Skill at interacting with Concord. 5% Bonus to effective security rating increase.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3355" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="fastTalkMutator" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Financial Connections" groupID="278" typeID="16547">
            <description>Understanding of Corporate Finances.

Improves loyalty point gain by 5% per level when working for agents in the following corporation divisions:

Public Relations	
Marketing	
Legal	
Accounting	
Financial	
Distribution
</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3356" skillLevel="3" />
              <row typeID="3355" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="High Tech Connections" groupID="278" typeID="16552">
            <description>Understanding of high-tech corporate culture.

Improves loyalty point gain by 5% per level when working for agents in the following corporation divisions:
 
Archives
Advisory
Intelligence
Manufacturing
Surveillance
</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3402" skillLevel="3" />
              <row typeID="3355" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Labor Connections" groupID="278" typeID="16550">
            <description>Understanding of corporate culture on the industrial level and the plight of the worker.

Improves loyalty point gain by 5% per level when working for agents in the following corporation divisions:   

Manufacturing
Production
Personnel
Mining
Astrosurveying
</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3380" skillLevel="3" />
              <row typeID="3355" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Military Connections" groupID="278" typeID="16549">
            <description>Understanding of military culture.

Improves loyalty point gain by 5% per level when working for agents in the following corporation divisions:

Intelligence
Security	
Astrosurveying	
Command	
Internal Security	
Surveillance
</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3355" skillLevel="3" />
              <row typeID="3348" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Negotiation" groupID="278" typeID="3356">
            <description>Skill at agent negotiation.  Improves agent effective quality.  5% additional pay per skill level for agent missions.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3355" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="negotiationBonus" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Political Connections" groupID="278" typeID="16548">
            <description>Understanding of political concepts and stratagems.

Improves loyalty point gain by 5% per level when working for agents in the following corporation divisions: 

Security
Legal
Administration
Advisory
Command	
Public Relations
</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3355" skillLevel="3" />
              <row typeID="3357" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Social" groupID="278" typeID="3355">
            <description>Skill at social interaction. 5% Bonus to NPC agent, corporation and faction standing increase.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="socialBonus" bonusValue="10" />
              <row bonusType="socialMutator" bonusValue="5" />
            </rowset>
          </row>
          <row typeName="Trade Connections" groupID="278" typeID="16551">
            <description>Understanding of the way trade is conducted at the corporate level.

Improves loyalty point gain by 5% per level when working for agents in the following corporation divisions:     

Distribution
Storage
Production
Accounting
Mining
Marketing
</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3443" skillLevel="3" />
              <row typeID="3355" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>intelligence</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
        </rowset>
      </row>
      <row groupName="Spaceship Command" groupID="257">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Advanced Spaceship Command" groupID="257" typeID="20342">
            <description>The advanced operation of spaceships. Grants a 5% Bonus per skill level to the agility of ships requiring Advanced Spaceship Command. Cannot be trained on Trial Accounts.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="agilityBonus" bonusValue="-5" />
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Amarr Battleship" groupID="257" typeID="3339">
            <description>Skill at operating Amarr battleships. Can not be trained on Trial Accounts.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="4" />
              <row typeID="3335" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Amarr Carrier" groupID="257" typeID="24311">
            <description>Skill at operating Amarr carriers.</description>
            <rank>14</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20533" skillLevel="3" />
              <row typeID="3339" skillLevel="5" />
              <row typeID="3442" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Amarr Cruiser" groupID="257" typeID="3335">
            <description>Skill at operating Amarr cruisers.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3331" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="shipPowerBonus" bonusValue="2" />
            </rowset>
          </row>
          <row typeName="Amarr Dreadnought" groupID="257" typeID="20525">
            <description>Skill at operating Amarr dreadnoughts. Can not be trained on Trial Accounts.</description>
            <rank>12</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20533" skillLevel="1" />
              <row typeID="3339" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Amarr Freighter" groupID="257" typeID="20524">
            <description>Skill at operating Amarr freighters. Can not be trained on Trial Accounts.</description>
            <rank>10</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20342" skillLevel="1" />
              <row typeID="3343" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Amarr Frigate" groupID="257" typeID="3331">
            <description>Skill at operating Amarr frigates.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Amarr Industrial" groupID="257" typeID="3343">
            <description>Skill at operating Amarr industrial ships. Can not be trained on Trial Accounts.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3331" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Amarr Titan" groupID="257" typeID="3347">
            <description>Skill at operating Amarr titans.</description>
            <rank>16</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20533" skillLevel="5" />
              <row typeID="3339" skillLevel="5" />
              <row typeID="3348" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Assault Ships" groupID="257" typeID="12095">
            <description>Skill for operation of the Assault Ship class frigates. Can not be trained on Trial Accounts.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3413" skillLevel="5" />
              <row typeID="3392" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Battlecruisers" groupID="257" typeID="12099">
            <description>Skill at operating Battlecruisers. Can not be trained on Trial Accounts.</description>
            <rank>6</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Black Ops" groupID="257" typeID="28656">
            <description>Skill for the operation of Black Ops. Can not be trained on Trial Accounts.</description>
            <rank>10</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="11579" skillLevel="4" />
              <row typeID="21611" skillLevel="4" />
              <row typeID="3327" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Caldari Battleship" groupID="257" typeID="3338">
            <description>Skill at operating Caldari battleships. Can not be trained on Trial Accounts.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="4" />
              <row typeID="3334" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Caldari Carrier" groupID="257" typeID="24312">
            <description>Skill at operating Caldari carriers.</description>
            <rank>14</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20533" skillLevel="3" />
              <row typeID="3338" skillLevel="5" />
              <row typeID="3442" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Caldari Cruiser" groupID="257" typeID="3334">
            <description>Skill at operating Caldari cruisers.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3330" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Caldari Dreadnought" groupID="257" typeID="20530">
            <description>Skill at operating Caldari dreadnoughts. Can not be trained on Trial Accounts.</description>
            <rank>12</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20533" skillLevel="1" />
              <row typeID="3338" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Caldari Freighter" groupID="257" typeID="20526">
            <description>Skill at operating Caldari freighters. Can not be trained on Trial Accounts.</description>
            <rank>10</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20342" skillLevel="1" />
              <row typeID="3342" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Caldari Frigate" groupID="257" typeID="3330">
            <description>Skill at operating Caldari frigates.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Caldari Industrial" groupID="257" typeID="3342">
            <description>Skill at operating Caldari industrial ships. Can not be trained on Trial Accounts.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3330" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="shieldRechargerateBonus" bonusValue="5" />
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Caldari Titan" groupID="257" typeID="3346">
            <description>Skill at operating Caldari titans.</description>
            <rank>16</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20533" skillLevel="5" />
              <row typeID="3338" skillLevel="5" />
              <row typeID="3348" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Capital Industrial Ships" groupID="257" typeID="28374">
            <description>Skill at operating Capital Industrial Ships

Cannot be trained on trial accounts.</description>
            <rank>12</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20342" skillLevel="5" />
              <row typeID="17940" skillLevel="5" />
              <row typeID="20533" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Capital Ships" groupID="257" typeID="20533">
            <description>The operation of capital ships.  Grants a 5% bonus per skill level to the agility of ships requiring the Capital Ships skill.  Cannot be trained on Trial Accounts.</description>
            <rank>14</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20342" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="agilityBonus" bonusValue="-5" />
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Command Ships" groupID="257" typeID="23950">
            <description>Skill for the operation of Command Ships. Can not be trained on Trial Accounts.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="12099" skillLevel="5" />
              <row typeID="3354" skillLevel="4" />
              <row typeID="3327" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Covert Ops" groupID="257" typeID="12093">
            <description>Covert operations frigates are designed for recon and espionage operation. Their main strength is the ability to travel unseen through enemy territory and to avoid unfavorable encounters  Much of their free space is sacrificed to house an advanced spatial field control system. This allows it to utilize very advanced forms of cloaking at greatly reduced CPU cost. Can not be trained on Trial Accounts.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3432" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Destroyers" groupID="257" typeID="12097">
            <description>Skill at operating Destroyers.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Electronic Attack Ships" groupID="257" typeID="28615">
            <description>Covert operations frigates are designed for recon and espionage operation. Their main strength is the ability to travel unseen through enemy territory and to avoid unfavorable encounters  Much of their free space is sacrificed to house an advanced spatial field control system. This allows it to utilize very advanced forms of cloaking at greatly reduced CPU cost. Can not be trained on Trial Accounts.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3432" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Exhumers" groupID="257" typeID="22551">
            <description>Skill for the operation of elite mining barges. Can not be trained on Trial Accounts.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="4" />
              <row typeID="3380" skillLevel="5" />
              <row typeID="3410" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Gallente Battleship" groupID="257" typeID="3336">
            <description>Skill at operating Gallente battleships. Can not be trained on Trial Accounts.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="4" />
              <row typeID="3332" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Gallente Carrier" groupID="257" typeID="24313">
            <description>Skill at operating Gallente carriers.</description>
            <rank>14</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20533" skillLevel="3" />
              <row typeID="3336" skillLevel="5" />
              <row typeID="3442" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Gallente Cruiser" groupID="257" typeID="3332">
            <description>Skill at operating Gallente cruisers.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3328" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Gallente Dreadnought" groupID="257" typeID="20531">
            <description>Skill at operating Gallente dreadnoughts. Can not be trained on Trial Accounts.</description>
            <rank>12</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20533" skillLevel="1" />
              <row typeID="3336" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Gallente Freighter" groupID="257" typeID="20527">
            <description>Skill at operating Gallente freighters. Can not be trained on Trial Accounts.</description>
            <rank>10</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20342" skillLevel="1" />
              <row typeID="3340" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Gallente Frigate" groupID="257" typeID="3328">
            <description>Skill at operating Gallente frigates.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Gallente Industrial" groupID="257" typeID="3340">
            <description>Skill at operating Gallente industrial ships. Can not be trained on Trial Accounts.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3328" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Gallente Titan" groupID="257" typeID="3344">
            <description>Skill at operating Gallente titans.</description>
            <rank>16</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20533" skillLevel="5" />
              <row typeID="3336" skillLevel="5" />
              <row typeID="3348" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Heavy Assault Ships" groupID="257" typeID="16591">
            <description>Skill for operation of the Heavy Assault class cruisers. Can not be trained on Trial Accounts.</description>
            <rank>6</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="12095" skillLevel="4" />
              <row typeID="3318" skillLevel="5" />
              <row typeID="3327" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Heavy Interdictors" groupID="257" typeID="28609">
            <description>Skill for operation of the Heavy Interdictor class cruisers. Can not be trained on Trial Accounts.</description>
            <rank>6</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3435" skillLevel="5" />
              <row typeID="3318" skillLevel="5" />
              <row typeID="3327" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Interceptors" groupID="257" typeID="12092">
            <description>The Operation Of Advanced Interceptor class Frigates.  Can not be trained on Trial Accounts.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3453" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Interdictors" groupID="257" typeID="12098">
            <description>The Operation Of Advanced Interdictor class Destroyers. Can not be trained on Trial Accounts.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="4" />
              <row typeID="12092" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Jump Freighters" groupID="257" typeID="29029">
            <description>Skill for operation of the Jump Freighter class freighters. Can not be trained on Trial Accounts.</description>
            <rank>14</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3380" skillLevel="5" />
              <row typeID="20342" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Logistics" groupID="257" typeID="12096">
            <description>Skill at operating Support Cruisers. Can not be trained on Trial Accounts.</description>
            <rank>6</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3431" skillLevel="5" />
              <row typeID="3428" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Marauders" groupID="257" typeID="28667">
            <description>Skill for the operation of Marauder. Can not be trained on Trial Accounts.</description>
            <rank>10</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3424" skillLevel="5" />
              <row typeID="11207" skillLevel="5" />
              <row typeID="3327" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Mining Barge" groupID="257" typeID="17940">
            <description>Skill at operating ORE Mining Barges. Can not be trained on Trial Accounts.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3410" skillLevel="3" />
              <row typeID="3380" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Minmatar Battleship" groupID="257" typeID="3337">
            <description>Skill at operating Minmatar battleships. Can not be trained on Trial Accounts.</description>
            <rank>8</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="4" />
              <row typeID="3333" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Minmatar Carrier" groupID="257" typeID="24314">
            <description>Skill at operating Minmatar carriers.</description>
            <rank>14</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20533" skillLevel="3" />
              <row typeID="3337" skillLevel="5" />
              <row typeID="3442" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Minmatar Cruiser" groupID="257" typeID="3333">
            <description>Skill at operating Minmatar cruisers.</description>
            <rank>5</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3329" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Minmatar Dreadnought" groupID="257" typeID="20532">
            <description>Skill at operating Minmatar dreadnoughts. Can not be trained on Trial Accounts.</description>
            <rank>12</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20533" skillLevel="1" />
              <row typeID="3337" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Minmatar Freighter" groupID="257" typeID="20528">
            <description>Skill at operating Minmatar freighters. Can not be trained on Trial Accounts.</description>
            <rank>10</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20342" skillLevel="1" />
              <row typeID="3341" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Minmatar Frigate" groupID="257" typeID="3329">
            <description>Skill at operating Minmatar frigates.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Minmatar Industrial" groupID="257" typeID="3341">
            <description>Skill at operating Minmatar industrial ships. Can not be trained on Trial Accounts.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3329" skillLevel="3" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Minmatar Titan" groupID="257" typeID="3345">
            <description>Skill at operating Minmatar titans.</description>
            <rank>16</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="20533" skillLevel="5" />
              <row typeID="3337" skillLevel="5" />
              <row typeID="3348" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Recon Ships" groupID="257" typeID="22761">
            <description>Skill for the operation of Recon Ships.  Can not be trained on Trial Accounts.</description>
            <rank>6</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="12093" skillLevel="4" />
              <row typeID="3431" skillLevel="5" />
              <row typeID="3327" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Spaceship Command" groupID="257" typeID="3327">
            <description>The basic operation of spaceships. 2% improved ship agility for all ships per skill level.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>perception</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="agilityBonus" bonusValue="-2" />
              <row bonusType="maxAttackTargets" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Transport Ships" groupID="257" typeID="19719">
            <description>Skill for operation of the Transport Ship class industrials. Can not be trained on Trial Accounts.</description>
            <rank>6</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3327" skillLevel="3" />
              <row typeID="3380" skillLevel="5" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>perception</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
        </rowset>
      </row>
      <row groupName="Trade" groupID="274">
        <rowset name="skills" key="typeID" columns="typeName,groupID,typeID">
          <row typeName="Accounting" groupID="274" typeID="16622">
            <description>Proficiency at squaring away the odds and ends of business transactions, keeping the check books tight.  Each level of skill reduces transaction tax by 10%.
</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3443" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Broker Relations" groupID="274" typeID="3446">
            <description>Proficiency at driving down market-related costs.  Each level of skill grants a 5% reduction in the costs associated with setting up a market order, which usually come to 1% of the order's total value. This can be further influenced by the player's standing towards the owner of the station where the order is entered.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3443" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Contracting" groupID="274" typeID="25235">
            <description>This skill allows you to create formal agreements with other characters. 

For each level of this skill the number of outstanding contracts is increased by four (up to a maximum of 21 at level 5)

Note: Cannot be trained on trial accounts</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3355" skillLevel="1" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="canNotBeTrainedOnTrial" bonusValue="1" />
            </rowset>
          </row>
          <row typeName="Corporation Contracting" groupID="274" typeID="25233">
            <description>You are familiar with the intricacies of formalizing contracts between your corporation and other entities. 

For each level of this skill the number of concurrent corporation/alliance contracts you make on behalf of your corporation is increased by 10 up to a maximum of 60. 

This skill has no effect on contracts you make personally.

There is no limit on the number of contracts a corporation can assign to itself.

Corporations have a hard limit of 500 outstanding public contracts.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="25235" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>willpower</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Daytrading" groupID="274" typeID="16595">
            <description>Allows for remote modification of buy and sell orders.  Each level of skill increases the range at which orders may be modified. Level 1 allows for modification of orders within the same solar system, Level 2 extends that range to systems within 5 jumps, and each subsequent level then doubles it. Level 5 allows for market order modification anywhere within current region.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3443" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Margin Trading" groupID="274" typeID="16597">
            <description>Ability to make potentially risky investments work in your favor.  Each level of skill reduces the percentage of ISK placed in market escrow when entering buy orders. Starting with an escrow percentage of 100% at Level 0 (untrained skill), each skill level cumulatively reduces the percentage by 25%. For a maximum reduction of ~24% total escrow at level 5.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="16622" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Marketing" groupID="274" typeID="16598">
            <description>Skill at selling items remotely. Each level increases the range from the seller to the item being sold. Level 1 allows for the sale of items within the same solar system, Level 2 extends that range to systems within 5 jumps, and each subsequent level then doubles it. Level 5 allows for sale of items located anywhere within current region.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3443" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Procurement" groupID="274" typeID="16594">
            <description>Proficiency at placing remote buy orders on the market.  Level 1 allows for the placement of orders within the  same solar system, Level 2 extends that range to systems within 5 jumps, and each subsequent level then doubles it.  Level 5 allows for placement of remote buy orders anywhere within current region.  

Note: placing buy orders and directly buying an item are not the same thing.  Direct remote purchase requires no skill.
</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="16598" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Retail" groupID="274" typeID="3444">
            <description>Ability to organize and manage market operations.  Each level raises the limit of active orders by 8.</description>
            <rank>2</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3443" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Trade" groupID="274" typeID="3443">
            <description>Knowledge of the market and skill at manipulating it. Active sell order limit increased by 4 per level of skill.</description>
            <rank>1</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel" />
            <requiredAttributes>
              <primaryAttribute>willpower</primaryAttribute>
              <secondaryAttribute>charisma</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue">
              <row bonusType="tradePremiumBonus" bonusValue="-5" />
            </rowset>
          </row>
          <row typeName="Tycoon" groupID="274" typeID="18580">
            <description>Ability to organize and manage ultra large-scale market operations.  Each level raises the limit of active orders by 32.</description>
            <rank>6</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="16596" skillLevel="5" />
              <row typeID="16598" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Visibility" groupID="274" typeID="3447">
            <description>Skill at acquiring products remotely.  Each level of skill increases your remote buy order range. Level 1 allows for the placing of buy orders within the same solar system, Level 2 extends that range to systems within 5 jumps, and each subsequent level then doubles it. Level 5 allows for a full regional range.

Note: Only remotely placed buy orders (using Procurement) require this skill to alter the range.  Any range can be set on a local buy order with no skill.</description>
            <rank>3</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="16594" skillLevel="4" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
          <row typeName="Wholesale" groupID="274" typeID="16596">
            <description>Ability to organize and manage large-scale market operations.  Each level raises the limit of active orders by 16.</description>
            <rank>4</rank>
            <rowset name="requiredSkills" key="typeID" columns="typeID,skillLevel">
              <row typeID="3444" skillLevel="5" />
              <row typeID="16598" skillLevel="2" />
            </rowset>
            <requiredAttributes>
              <primaryAttribute>charisma</primaryAttribute>
              <secondaryAttribute>memory</secondaryAttribute>
            </requiredAttributes>
            <rowset name="skillBonusCollection" key="bonusType" columns="bonusType,bonusValue" />
          </row>
        </rowset>
      </row>
    </rowset>
  </result>
  <cachedUntil>2008-01-17 00:36:57</cachedUntil>
</eveapi>