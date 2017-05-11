package build;

public class PjBuilder extends PersonagensBuilder {
	private String nome;
	private String classe;
	private String equips;
	
	public PjBuilder(String nome, String classe, String equips){
		this.nome = nome;
		this.classe = classe;
		this.equips = equips;
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
		personagen.equips = getEquips();
	}
	
	public String getNome() {
		return nome;
	}

	public String getClasse() {
		return classe;
	}

	public String getEquips() {
		return equips;
	}

	void ataca(){
		
	}
	
	void defende(){
		
	}
}
