using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;

namespace HW_CS_9_Tamagochi {

    enum  PetNeeds : uint { Eat, Walk, Sleep, Play, Doctor };
    delegate void NeedsDelegate(object odj);
    class NeedsItem : IComparable<NeedsItem> {
        private PetNeeds need;
        public event NeedsDelegate action;

        public NeedsItem(PetNeeds need, NeedsDelegate D) {
            this.need = need;
            action += D;
        }

        public void DoWork(object obj) {
            action?.Invoke(obj);
        }

        public int CompareTo(NeedsItem obj) {
            return need.CompareTo(obj.need);
        }
    }
	class Game {
        private static System.Timers.Timer gTimer;
        private static PetNeeds PetNeedRnd { get => (PetNeeds) new Random().Next(Enum.GetValues(typeof (PetNeeds)).Length-1); }
        private List<NeedsItem> needs;
        private int afflictionCnt;      //счетчик отказов
        private bool isGotSick;         //заболел
        private bool isDead;            //умер
        public static bool timerTick;   //тик таймера


        public Game() {
            gTimer = new System.Timers.Timer();
            gTimer.Interval = 5000;
            gTimer.Elapsed += T_Elapsed;
            gTimer.AutoReset = true;
            gTimer.Enabled = false;

            afflictionCnt = 0;
            isDead = false;

            timerTick = false;

            needs = new List<NeedsItem> {
                new NeedsItem(PetNeeds.Eat, obj => NeedEat()),
                new NeedsItem(PetNeeds.Walk, obj => NeedWalk()),
                new NeedsItem(PetNeeds.Sleep, obj => NeedSleep()),
                new NeedsItem(PetNeeds.Play, obj => NeedPlay()),
                new NeedsItem(PetNeeds.Doctor, obj => NeedDoctor())                
            };

        }

        
        public void Start() {        
            GRFX.WriteGameCanvas();
            GRFX.ShowPet(5, 5);
            gTimer.Enabled = true;
            gTimer.Start();
            while (true) {
                if(timerTick == true) {
                    if (isDead) {
                        GRFX.ShowDead();
                        break;
                    }
                    if (!isGotSick)
                        needs[(int)PetNeedRnd].DoWork(new object());
                    else
                        needs[(int)PetNeeds.Doctor].DoWork(new object());
                    timerTick = false;
                }
            }
        }

        private bool ValidateNeeds(string msg) {
                string message = msg;
                string caption = "Pet needs!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
            return (result == System.Windows.Forms.DialogResult.Yes);
        }
        private void NeedEat() {
            if (ValidateNeeds("I need eat. Feed me?"))
                afflictionCnt = 0;
            else
                if (++afflictionCnt >= 3) isGotSick = true;
        }

        private void NeedWalk() {
            if (ValidateNeeds("I need Walk. Take a walk with me?"))
                afflictionCnt = 0;
            else
                if (++afflictionCnt >= 3) isGotSick = true;
        }

        private void NeedSleep() {
            if (ValidateNeeds("I need Sleep. Will you put me to sleep?"))
                afflictionCnt = 0;
            else
                if (++afflictionCnt >= 3) isGotSick = true;
        }

        private void NeedPlay() {
            if (ValidateNeeds("I want to play. Will you play with me?"))
                afflictionCnt = 0;
            else
                if (++afflictionCnt >= 3) isGotSick = true;
        }

        private void NeedDoctor() {
            if (ValidateNeeds("I got sick. Will you help me?")) {
                afflictionCnt = 0;
                isGotSick = false;
            } else
                isDead = true;
        }
        private static void T_Elapsed(object sender, ElapsedEventArgs e) {
            Game.timerTick = true;
        }
	}
}
