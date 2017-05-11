package build;

public class PnjBuild extends PersonagensBuilder {
	private String nome;
	private String classe;
	
	public PnjBuild(String nome, String classe) {
		this.nome = nome;
		this.classe = classe;
	}
	
	public String getNome() {
		return nome;
	}

	public String getClasse() {
		return classe;
	}

	@Override 
	void buildNome(){
		 personagen.nome = getNome();
	 }
	
	@Override
	 void buildClasse(){
		personagen.classe = getClasse();
	}
	
	@Override
	 void buildEquips(){
		personagen.equips = null;
	}

}
