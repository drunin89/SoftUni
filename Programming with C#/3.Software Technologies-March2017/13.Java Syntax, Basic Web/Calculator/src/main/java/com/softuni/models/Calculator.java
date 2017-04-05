package com.softuni.models;


public class Calculator {
    private double leftOperand;
    private String operator;
    private double rightOperand;

    public Calculator(double leftOperand, String operator, double rightOperand) {
        this.leftOperand = leftOperand;
        this.operator = operator;
        this.rightOperand = rightOperand;
    }

    public double getLeftOperand() {
        return leftOperand;
    }

    public void setLeftOperand(double leftOperand) {
        this.leftOperand = leftOperand;
    }

    public String getOperator() {
        return operator;
    }

    public void setOperator(String operator) {
        this.operator = operator;
    }

    public double getRightOperand() {
        return rightOperand;
    }

    public void setRightOperand(double rightOperand) {
        this.rightOperand = rightOperand;
    }

    public double calculateResult() {
        double result;

        switch(operator) {
            case "+": result = this.getLeftOperand() + this.getRightOperand();
                break;
            case "-": result = this.getLeftOperand() - this.getRightOperand();
                break;
            case "*": result = this.getLeftOperand() * this.getRightOperand();
                break;
            case "/": result = this.getLeftOperand() / this.getRightOperand();
                break;
            default: result = 0;
            break;

        }

        return result;
    }


}
