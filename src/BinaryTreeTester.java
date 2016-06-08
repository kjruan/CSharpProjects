import java.io.*;

public class BinaryTreeTester {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		BinaryTree binaryTree = null;
		
		try {
			ObjectInputStream in = new ObjectInputStream(new FileInputStream("test"));
			binaryTree = (BinaryTree) in.readObject();
		} catch (Exception ex) {
			ex.printStackTrace();
			System.exit(1);
		}
		
		try {
			ObjectOutputStream out = new ObjectOutputStream(new FileOutputStream("test"));
			out.writeObject(binaryTree);
		} catch (Exception ex) {
			ex.printStackTrace();
			System.exit(1);
		}
	}

}
