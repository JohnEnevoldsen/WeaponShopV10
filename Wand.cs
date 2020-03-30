namespace WeaponShopV10
{
    /// <summary>
    /// This class represents a Wand. A Wand is 
    /// considered to be a weapon.
    /// </summary>
    public class Wand : Weapon
    {
        private bool _isEnchanted;
        public const int InitialWandMinDamage = 10;
        public const int InitialWandMaxDamage = 30;

        public bool IsEnchanted{
            get{return _isEnchanted;}
            set{_isEnchanted = value;}
        }

        #region Constructor
        public Wand(string description) 
            : base(description, InitialWandMinDamage, InitialWandMaxDamage)
        {
            _isEnchanted = false;
        } 
        #endregion
        public int DamageFromWand(){
            if(_isEnchanted){
                return base.CalculateDamage() * 2;
            }
            return base.CalculateDamage();
        }
    }
}