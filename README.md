# Demo-game — Weapon Sandbox

Weapon test sandbox scripts (`Assets/_WeaponTest`) for a Unity 6000.3 project.

These scripts reference the host project's data types (`Weapon`, `BulletType`, `MechaDataBase`,
`WeaponJoin`, `DamageBase` subclasses, ...). They do not compile on their own and contain no game assets.

## Contents
- `WeaponTestPlayer` — assembles a mech from `MechaDataBase`, WASD move, mouse aim, weapon switching.
- `WeaponTestGun` — fires one weapon; behaviour chosen from the bullet prefab class
  (Projectile, Shotgun, Homing, Boomerang, Beam, Chain, AreaAtTarget, Mine, Aura).
- `WeaponTestProjectile` — straight / homing / boomerang flight, swept hit test, pierce, ricochet, explosion.
- `WeaponTestZone` — area, aura, mine and beam damage.
- `WeaponTestTarget`, `WeaponTestHud` — dummy targets and debug HUD.
- `WeaponTestSmokeRunner` + `Editor/WeaponTestSmokeLauncher` — automated pass over every weapon.
- `Editor/WeaponTestSceneBuilder` — `Tools/Weapon Test/Create Sandbox Scene`.

## Keys
WASD move · LMB fire · F auto-fire · C continuous · Q/E weapon · Z/X level · V evolutions · Tab mech · R heal targets

## Smoke test
```
Unity.exe -projectPath <project> -executeMethod WeaponTest.EditorTools.WeaponTestSmokeLauncher.RunAndExit [-smokeFilter "Gatling,Railgun"]
```
