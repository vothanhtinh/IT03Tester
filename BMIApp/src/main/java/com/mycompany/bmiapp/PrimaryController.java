package com.mycompany.bmiapp;

import java.io.IOException;
import javafx.fxml.FXML;

public class PrimaryController {

    @FXML
    private void switchToSecondary() throws IOException {
        
        int ab=10;
        if(ab>0)
         App.setRoot("secondary");
    }
}
