package build;

public class Main {

	public static void main(String[] args) {
		int cont=0;
		
		CriadorDePersonagens[] lobisomem = new CriadorDePersonagens[15];
		for(int i = 0; i < lobisomem.length; i++){
			lobisomem[i] = new CriadorDePersonagens(new PnjBuild("Lobisomem", "Lobisomem"));
			lobisomem[i].criarPersonagem();
			cont = i+1;
			Personagens personagen = lobisomem[i].getPersonagen();
			System.out.println("Nome:" + personagen.nome + "Nº"+ cont + "; " + 
					"Classe: " + personagen.classe +".");
		}
		
		CriadorDePersonagens[] dragao = new CriadorDePersonagens[2];
		for(int i = 0; i < dragao.length; i++){
			dragao[i] = new CriadorDePersonagens(new PnjBuild("Dragao", "Dragao"));
			dragao[i].criarPersonagem();
			cont = i+1;
			Personagens personagen = dragao[i].getPersonagen();
			System.out.println("Nome:" + personagen.nome + "Nº"+ cont + "; " +  
					"Classe: " + personagen.classe +". Nª");
		}
		
		CriadorDePersonagens[] vampiro = new CriadorDePersonagens[15];
		for(int i = 0; i < vampiro.length; i++){
			vampiro[i] = new CriadorDePersonagens(new PnjBuild("Vampiro", "Vampiro"));
			vampiro[i].criarPersonagem();
			cont = i+1;
			Personagens personagen = vampiro[i].getPersonagen();
			System.out.println("Nome:" + personagen.nome + "Nº"+ cont + "; " +  
					"Classe: " + personagen.classe +".");
		}
		CriadorDePersonagens pj = new CriadorDePersonagens(
				new PjBuilder("sr.jhon", "cavaleiro", "escudo"));
		pj.criarPersonagem();
		Personagens persona = pj.getPersonagen();
		System.out.println( "NOME: " + persona.nome +
							" CLASSE: " + persona.classe + 
							" EQUIPAMENTO: " + persona.equips);
	}
	
}
