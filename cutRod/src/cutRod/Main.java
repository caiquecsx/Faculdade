package cutRod;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;

public class Main {
	
	public static class RodDivision {

	    private static Scanner fileScanner;

		public static int divideRod(ArrayList<Integer> valores, int[] tamanhoBarra, int n){
			
	        if(n==0) return 0;
	        
	        if(tamanhoBarra[n]!=-1) return tamanhoBarra[n];
	        
	        int max=-1, res;
	        for(int i=1; i<=n; i++){
	            res=valores.get(i)+divideRod(valores, tamanhoBarra, n-i);
	            if(res>max)
	                max=res;
	        }
	        tamanhoBarra[n]=max;
	        return max;
	    }

	    /**
	     * @param args
	     * @throws FileNotFoundException 
	     */
	    public static void main(String[] args) throws FileNotFoundException {
	        fileScanner = new Scanner(new File("texto.txt"));
	    	ArrayList<Integer> valores = new ArrayList<Integer>(); //tamanho da haste
	    	
	    	//guardando os valores da haste em um array
	    	while(fileScanner.hasNext()){
	    		valores.add(fileScanner.nextInt());
	    	}
	    	//n possui o tamanho da haste
	        int n=valores.size()-1;
	        
	        //tabela com as respostas
	        int[] tamanhoBarra=new int[valores.size()];
	        //passa -1 para todos as posições para o teste futuro
	        for(int i=0;i<tamanhoBarra.length; i++)
	            tamanhoBarra[i]=-1;
	        
	        System.out.println(divideRod(valores, tamanhoBarra, n));
	    }

	}

}
