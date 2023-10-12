# 2DRogue 박종수
CameraFollowPlayer.cs : 이 스크립트는 FixedUpdate에서 플레이어를 따라가는 카메라의 동작을 구현하고 있습니다. 카메라는 주기적으로 플레이어의 위치를 확인하고 부드럽게 이동하여 따라갑니다.
CurrentPickUp.cs : PlayerStats 클래스의 코인 또는 젬을 늘리는 코드
Enemy.cs : 적 캐릭터(Enemy)를 관리
EnemyAttack.cs : 적의 공격을 관리
EnemySpawner.cs : 적 생성,무한 루프를 통해 지속적으로 적을 생성하며, 각 적은 랜덤한 위치에 생성됩니다.
FloatToPlayer.cs : 적이 플레이어를 향해 일정한 속도로 이동하는 역할을 합니다. Update 함수에서 매 프레임마다 플레이어 캐릭터를 향해 이동하도록 설정되어 있습니다. 이때 플레이어가 존재하는지 확인하고, 존재한다면 이동 명령을 수행합니다.
MainMenu.cs : Menu
PlayerMovement.cs : 플레이어 이동, 대쉬
PlayerStats.cs : 플레이어 상태창, 골드와 보석양 체크
TestEnemyProjectile.cs : 적 발사체 관리,태그 사용
TestEnemyShooting.cs : 적이 플레이어 공격,**코루틴 사용**
TestProjectile.cs : 이 코드는 적의 프로젝타일이 플레이어에게 닿았을 때 플레이어에게 데미지를 주고, 프로젝타일을 파괴하는 역할을 합니다.
TestSpell.cs : 플레이어가 적을 공격
