package java_android.hw_1;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.graphics.Color;
import android.graphics.Point;
import android.support.annotation.ColorInt;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.MotionEvent;
import android.view.View;
import android.widget.TableLayout;
import android.widget.TextView;

public class Task2_Activity extends AppCompatActivity {


    @SuppressLint("ClickableViewAccessibility")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_task2);

        TableLayout TL = (TableLayout)findViewById(R.id.Background_main);
        TL.setOnTouchListener(new onMotion(this));

    }

    public static final class onMotion implements View.OnTouchListener {
        private final Activity parent;
        private float stX = 0f;
        private float stY = 0f;
        private boolean isSwap = false;

        public onMotion(Activity activity){
            parent = activity;
        }

        @SuppressLint("ClickableViewAccessibility")
        @Override
        public boolean onTouch(View v, MotionEvent event) {
            int action = event.getAction();
            float x = event.getX();
            float y = event.getY();


            StringBuilder str = new StringBuilder("Action:");
            TextView tv = (TextView)parent.findViewById(R.id.tvMotionInfo);
            TableLayout TL = (TableLayout)parent.findViewById(R.id.Background_main);

            switch (action){
                case MotionEvent.ACTION_DOWN:
                    str.append(" Push down");
                    stX = x;
                    stY = y;
                break;
                case MotionEvent.ACTION_MOVE:
                    str.append(" Swap");
                    isSwap = true;
                    break;
                case MotionEvent.ACTION_UP:
                    str.append(" Push up");

                    if(!isSwap || (Math.abs(stX - x) <= 50 && Math.abs(stY - y) <= 50)){
                       return false;
                    }
                    if(Math.abs(stX - x) > 50 && Math.abs(stY - y) <= 50){
                        TL.setBackgroundColor(Color.GREEN);
                    } else if(Math.abs(stX - x) <= 50 && Math.abs(stY - y) > 50){
                        TL.setBackgroundColor(Color.YELLOW);
                    } else if(Math.abs(stX - x) > 50 && Math.abs(stY - y) > 50){
                        TL.setBackgroundColor(Color.RED);
                    }

                    isSwap = false;
                    break;
            }
            str.append(" X = ");
            str.append(x);
            str.append(" Y = ");
            str.append(y);

            tv.setText(str.toString());

            return false;
        }
    }
}