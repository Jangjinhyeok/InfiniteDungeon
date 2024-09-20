using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : Stat
{
    [SerializeField]
    protected int _exp;
    [SerializeField] 
    protected int _maxExp;
    [SerializeField]
    protected int _plusDamageLevel;
    [SerializeField] 
    protected int _plusHpLevel;

    public int Exp { get { return _exp; } set { _exp = value; } }
    public int MaxExp { get { return _maxExp; } set { _maxExp = value; } }
    public int PlusDamageLevel { get { return _plusDamageLevel; } set { _plusDamageLevel = value; } }
    public int PlusHpLevel { get { return _plusHpLevel; } set { _plusHpLevel = value; } }

    private void Start()
    {
        _speed = 5f;
        _maxHp = 100;
        _hp = 100;
        _exp = 0;
        _maxExp = 9;
        _level = 1;
    }
}
