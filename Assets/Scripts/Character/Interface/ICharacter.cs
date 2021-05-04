public interface ICharacter
{
    public void GetInfo();
    public void Heal(float health);
    public void TakeExp(float exp);
    public void GiveDamage(Character character);
    public void TakeDamage(float damage);
    public void CastTargetSpell(Character targetCharacter, int id);
    public void CastUnTargetSpell(int id);
    public void Die();
}