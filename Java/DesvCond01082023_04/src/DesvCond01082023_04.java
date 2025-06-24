import javax.swing.JOptionPane;

public class DesvCond01082023_04 {

	public static void main(String[] args) {
		if(JOptionPane.showConfirmDialog(null, "Escolha OK ou CANCELAR!", "Desvio Condicional", JOptionPane.CANCEL_OPTION, JOptionPane.QUESTION_MESSAGE)== JOptionPane.OK_OPTION) {
			JOptionPane.showMessageDialog(null, "Você escolheu OK!");
		}
		else {
			JOptionPane.showMessageDialog(null, "Você escolheu CANCELAR!");
		}
	}

}
