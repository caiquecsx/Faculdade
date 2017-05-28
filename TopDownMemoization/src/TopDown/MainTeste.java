package TopDown;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class MainTeste {
	public static int max(int a, int b) {
        return (a > b) ? a : b;

    }
	
	static int MemoizedCutRod(int[] piece, int lenght) {
		
		int [] r = new int[lenght+1];
		
		for (int i = 1; i <= lenght; i++) {
            r[i] = 0;
        }
		
		return MemoizedCutRodAux(piece, lenght, r);
	}
	
	static int MemoizedCutRodAux(int [] piece, int lenght, int [] r){
		
		if(r[lenght] >= 0){
			return r[lenght];
		}
		
		if(lenght == 0){
			return 0;
		}else{
			int q = lenght + 1;
			for(int i = 1; i <= lenght; i++){
				q = max(q,piece[i] + MemoizedCutRodAux(piece, lenght, r));
				r[lenght] = q;
			}
			return q;
		}		
	}
		public static void MainTeste(String[] args) throws FileNotFoundException {
			Scanner rod = new Scanner(new File("rod.txt"));
			ArrayList<Integer> pieces = new ArrayList<Integer>();
			
			while(rod.hasNextLine()){
				int token = rod.nextInt();
				pieces.add(token);
			}
			
			int[] pieceArray = new int[pieces.size()];
			
			for(int i = 0; i < pieces.size(); i++){
				if(pieces.get(i) != null){
					pieceArray[i] = pieces.get(i);
				}
			}
			
			int lenght = pieceArray.length;
			
			MemoizedCutRod(pieceArray, lenght);
		}
}
