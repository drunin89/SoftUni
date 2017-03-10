<?php
namespace CalculatorBundle\Entity;
class Calculator
{
    /*
     * @var float
     */
    private $leftOperand;
    /*
     * @var float
     */
    private $rightOperand;
     /*
     * @var string
     */
    private $operator;

    /*
     * Set left operand
     * @param float $operator
     * @return Calculator
     */
    public function getLeftOperand()
    {
    return $this->leftOperand;

    }
    public function setLeftOperand($operand)
    {
        $this->leftOperand = $operand;
        return $this;
    }
    /*
     * Set right operand
     * @param float $operator
     * @return Calculator
     */
    public function getRightOperand()
    {
        return $this->rightOperand;

    }
    public function setRightOperand($operand)
    {
        $this->rightOperand = $operand;
        return $this;
    }
    /*
     * Set right operand
     * @param string $operator
     * @return Calculator
     */
    public function getOperator()
    {
        return $this->operator;

    }
    public function setOperator($operator)
    {
        $this->operator = $operator;
        return $this;
    }
}

?>