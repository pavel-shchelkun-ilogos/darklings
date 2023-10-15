using Demonics;
using UnityEngine;

public class KnockdownHardState : State
{
    public override void UpdateLogic(PlayerNetwork player)
    {
        CheckFlip(player);
        if (!player.enter)
        {
            player.player.PlayerUI.DisplayNotification(NotificationTypeEnum.Knockdown);
            player.enter = true;
            player.animationFrames = 0;
            player.sound = "Landed";
            player.SetParticle("KnockdownHard", new DemonVector2(player.position.x, player.position.y - 15));
            player.velocity = new DemonVector2((DemonFloat)0, (DemonFloat)2.1f);
            player.framedataEnum = FramedataTypesEnum.Knockdown;
            return;
        }
        player.velocity = new DemonVector2(player.velocity.x, player.velocity.y - DemonicsPhysics.GRAVITY);
        player.animationFrames++;
        player.framedataEnum = FramedataTypesEnum.Knockdown;
        player.hurtbox.active = false;
        player.animation = "Knockdown";
        ToIdleState(player);
    }
    private void ToIdleState(PlayerNetwork player)
    {
        if (player.animationFrames >= 60)
            EnterState(player, "WakeUp");
    }
}