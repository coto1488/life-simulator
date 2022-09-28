﻿using life_simulator.Render;
using life_simulator.Plants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace life_simulator.Classes.Animal {
	internal class Herbivorous : Animal {
		public Herbivorous(World world) : base(world) {
			Render.SetSvg("assets/svg/Herbivorous.svg");
			Render.SetColor(Color.Green);
			Render.Rerender();
			SpeedCoof = 20;
		}

		public override void Tick() {
			base.Tick();
			Live<Plant, Plant>();
		}
	}
}
