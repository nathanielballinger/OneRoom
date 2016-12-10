﻿using UnityEngine;
using System.Collections;

public abstract class Command {

    public abstract void execute(ICommandable actor);
}
