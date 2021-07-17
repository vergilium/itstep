package java_android.hw_1;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.GridLayout;
import android.widget.TextView;

public class Task3_Activity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_task3);
         float val1;
         float val2;

    }

    @SuppressLint("SetTextI18n")
    public void CalcHandler(View v){
        if(v instanceof Button) {
            TextView display = (TextView)this.findViewById(R.id.number_display);
            String btn_val = ((Button) v).getText().toString();
            String display_text = display.getText().toString();
            if(Integer.parseInt(btn_val) >=0 && display_text.length() <= 12){
                if(!display_text.equals("0")){
                    display.setText(display_text + btn_val);
                } else {
                    display.setText(btn_val);
                }
            }
            switch(btn_val){
                case "+": break;
                case "-": break;
                case "/": break;
                case "*": break;
                case "=": break;
                default: break;
            }
        }
    }

}